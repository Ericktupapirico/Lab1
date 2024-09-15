using AEDLaboratorio2.Entities.DentalClinic;

namespace AEDLaboratorio2.Models.DentalClinic
{
    public class AppointmentModel
    {
        private int _size = 0, _quantity = 0;
        private static Appointment[] _appointments = [];

        public (bool result, string message) InitializeArray(int size)
        {
            if (size <= 0)
                return (false, "Tamaño del arreglo debe ser > 0");

            _size = size;
            _appointments = new Appointment[_size];

            return (true, "Arreglo creado exitosamente");
        }

        private int FindIndex(int appointmentId)
        {
            int index = -1;
            for (var i = 0; i < _quantity; i++)
                if (_appointments[i].Id == appointmentId)
                {
                    index = i;
                    return index;
                }

            return index;
        }

        private int FindIndexToInsert(DateTime scheduledDate)
        {
            int index = 0;

            while (index < _quantity && _appointments[index].ScheduledDate < scheduledDate)
                index++;

            if (index >= _quantity || _appointments[index].ScheduledDate > scheduledDate)
                return -index;

            return index;
        }

        private bool IsExistingId(int id)
        {
            for (var i = 0; i < _quantity; i++)
                if (_appointments[i].Id == id)
                    return true;

            return false;
        }

        public (bool result, string message) Add(Appointment appointment)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity >= _size)
                return (false, "No hay espacio en el arreglo para un nueva cita");

            if (IsExistingId(appointment.Id))
                return (false, "Ya existe una cita con el ID ingresado");

            var index = FindIndexToInsert(appointment.ScheduledDate);
            if (index > 0)
                return (false, "Ya existe una cita con el ID ingresado");

            index = -index;
            for (var i = _quantity; i > index; i--)
                _appointments[i] = _appointments[i - 1];

            _appointments[index] = appointment;
            ++_quantity;

            return (true, "Cita registrada exitosamente");
        }

        public (bool result, string message) Update(Appointment appointment)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity == 0)
                return (false, "No hay cita para actualizar");

            var (result, message) = Delete(appointment.Id);
            if (!result)
                return (false, message);

            var (result1, message1) = Add(appointment);
            if (!result1)
                return (false, message1);

            return (true, "Cita actualizada exitosamente");
        }

        public (bool result, string message) Delete(int id)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity == 0)
                return (false, "No hay citas para eliminar");

            var index = FindIndex(id);
            if (index < 0)
                return (false, "No existe una cita con el ID ingresado");

            for (int i = index; i < _quantity - 1; i++)
                _appointments[i] = _appointments[i + 1];

            --_quantity;

            return (true, "Cita eliminado exitosamente");
        }

        public (bool result, string message, Appointment? appointment) GetById(int id)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo", null);

            if (_quantity == 0)
                return (false, "No hay citas para buscar", null);

            var index = FindIndex(id);

            return id < 0 ? (false, "No existe una cita con el ID ingresado", null) :
                (true, $"Cita con Id: {id} encontrado", _appointments[index]);
        }

        public (bool result, string message, Appointment[] appointments) GetByMonth(int month)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo", []);

            if (_quantity == 0)
                return (false, "No hay citas para buscar", []);

            var appointments = _appointments
                .Take(_quantity).Where(a => a.ScheduledDate.Month == month).ToArray();

            return (true, "Citas encontradas", appointments);
        }

        public Appointment[] GetAll() => _appointments.Take(_quantity).ToArray();
    }
}