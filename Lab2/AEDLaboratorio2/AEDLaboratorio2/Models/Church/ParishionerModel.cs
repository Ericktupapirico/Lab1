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

        private int Search(int id)
        {
            int index = 0;
            while (index < _quantity && _parishioners[index].Id < id)
                index++;

            if (index >= _quantity || _parishioners[index].Id > id)
                return -index;

            return index;
        }

        public (bool result, string message) Add(Parishioner parishioner)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity >= _size)
                return (false, "No hay espacio en el arreglo para un nuevo feligrés");

            var index = Search(parishioner.Id);
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

            var index = Search(parishioner.Id);
            if (index < 0)
                return (false, "No existe un feligrés con el ID ingresado");

            _parishioners[index] = parishioner;

            return (true, "Feligrés actualizado exitosamente");
        }

        public (bool result, string message) Delete(int id)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo");

            if (_quantity == 0)
                return (false, "No hay feligrés para eliminar");

            var index = Search(id);
            if (index < 0)
                return (false, "No existe un feligrés con el ID ingresado");

            for (int i = index; i < _quantity - 1; i++)
                _parishioners[i] = _parishioners[i + 1];

            --_quantity;

            return (true, "Feligrés eliminado exitosamente");
        }

        public (bool result, string message, Parishioner? parishioner) Get(int id)
        {
            if (_size == 0)
                return (false, "Primero debe asignar un tamaño al arreglo", null);

            if (_quantity == 0)
                return (false, "No hay feligrés para buscar", null);

            var index = Search(id);

            return id < 0 ? (false, "No existe un feligrés con el ID ingresado", null) :
                (true, $"Feligrés con Id: {id} encontrado", _parishioners[index]);
        }

        public Parishioner[] GetAll() => _parishioners.Take(_quantity).ToArray();
    }
}