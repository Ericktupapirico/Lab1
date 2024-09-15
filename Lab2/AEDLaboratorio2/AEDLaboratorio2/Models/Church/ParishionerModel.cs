using AEDLaboratorio2.Entities.Church;

namespace AEDLaboratorio2.Models.Church
{
    public class ParishionerModel
    {
        private int _size = 0, _quantity = 0;
        private static Parishioner[] _parishioners = [];

        public (bool result, string message) InitializeArray(int size)
        {
            if (size <= 0)
                return (false, "Tamaño del arreglo debe ser > 0");

            _size = size;
            _parishioners = new Parishioner[_size];

            return (true, "Arreglo creado exitosamente");
        }

        private int SearchById(int id)
        {
            int index = -1;
            for (var i = 0; i < _quantity; i++)
                if (_parishioners[i].Id == id)
                {
                    index = i;
                    return index;
                }

            return index;
        }

        private bool IsExistingId(int id)
        {
            for (var i = 0; i < _quantity; i++)
                if (_parishioners[i].Id == id)
                    return true;

            return false;
        }

        private int FindIndexToInsert(decimal tithe)
        {
            int index = 0;

            /*
             * Lógica para encontrar la posición en el arreglo donde debe de ir el nuevo feligrés
             * en base a su total de diezmos dados, el total de diezmos dados se saca sumando cada
             * diezmo que haya dado el feligrés...
             */

            return index;
        }

        public (bool result, string message) Add(Parishioner parishioner)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity >= _size)
                return (false, "No hay espacio en el arreglo para un nuevo feligrés");

            if (IsExistingId(parishioner.Id))
                return (false, "Ya existe un feligrés con el ID ingresado");

            var index = SearchById(parishioner.Id);
            if (index > 0)
                return (false, "Ya existe un feligrés con el ID ingresado");

            index = -index;
            for (var i = _quantity; i > index; i--)
                _parishioners[i] = _parishioners[i - 1];

            _parishioners[index] = parishioner;
            ++_quantity;

            return (true, "Feligrés registrado exitosamente");
        }

        public (bool result, string message) Update(Parishioner parishioner)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity == 0)
                return (false, "No hay feligrés para actualizar");

            var (result, message) = Delete(parishioner.Id);
            if (!result)
                return (false, message);

            var (result1, message1) = Add(parishioner);
            if (!result1)
                return (false, message1);

            return (true, "Feligrés actualizado exitosamente");
        }

        public (bool result, string message) Delete(int id)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity == 0)
                return (false, "No hay feligrés para eliminar");

            var index = SearchById(id);
            if (index < 0)
                return (false, "No existe un feligrés con el ID ingresado");

            for (int i = index; i < _quantity - 1; i++)
                _parishioners[i] = _parishioners[i + 1];

            --_quantity;

            return (true, "Feligrés eliminado exitosamente");
        }

        public (bool result, string message, Parishioner? parishioner) GetById(int id)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo", null);

            if (_quantity == 0)
                return (false, "No hay feligrés para buscar", null);

            var index = SearchById(id);

            return id < 0 ? (false, "No existe un feligrés con el ID ingresado", null) :
                (true, $"Feligrés con Id: {id} encontrado", _parishioners[index]);
        }

        public Parishioner[] GetAll() => _parishioners.Take(_quantity).ToArray();
    }
}