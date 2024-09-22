using AEDLaboratorio2.Entities.Church;

namespace AEDLaboratorio2.Models.Church
{
   
        public class ParishionerModel
        {
            public static readonly ParishionerModel InstanceParishioner = new();//Se crea una instancia unica, mas que todo para evitar errores a futuro y asegurar un mejor manejo de la clase
            public static ParishionerModel arrayLogic { get { return InstanceParishioner; } }//se vuelve publica la instancia
            public Parishioner[] parishionerArray;//arreglo donde se guardaran los objetos
            int Size = 0, Quantity = 0;//Cantidad de registros y tamanio del arreglo
            public ParishionerModel()
            {
                parishionerArray = new Parishioner[Size];//se le asigna el tamanio al arreglo
            }

            public void AddParishioner(Parishioner parishioner)//Se verifica si el tamanio es menor a la cantidad de registro, de caso contrario se redomensiona el arreglo y se almeneca el objeto y la cantidad aumenta
            {

                if (Size <= Quantity)
                {
                    Size = Size == 0 ? 1 : Size + 1;
                    Array.Resize(ref parishionerArray, Size);
                }
                parishionerArray[Quantity] = parishioner;
                Array.Sort(parishionerArray, (firstParishion, SecondParishion) => SecondParishion?.Amount.CompareTo(firstParishion?.Amount) ?? 0);
                //compara los indices del arreglo en funcion del monto de diezmos de 2 en 2, si el primeo es mayor se mueve hacua arriba de caso contrsrio se mueva hacia abjo, si son iguales no hace su accion y sigue comparando otros indices
                MessageBox.Show("Parishioner save successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ++Quantity;
            }

            public Parishioner[] GetParisioner() { return parishionerArray; }//devuelve el arreglo de objetos para su visualizacion

            public bool DeleteParishioner(int id)//usando el id se ubica al objeto que se desea eliminar
            {
                var index = Array.FindIndex(parishionerArray, p => p.ID.Equals(id) == true);
                if (index < 0) return false;

                for (int i = index; i < Quantity - 1; i++)
                {
                    parishionerArray[i] = parishionerArray[i + 1];//desplaza todos los objetos hacia la izquieda menos al deseado dejandolo de ultimo a la derecha y se disminuye el tamanio para desechar el objeto elimminado
                }
                --Quantity;
                Array.Resize(ref parishionerArray, Quantity);
                return true;

            }

            public Parishioner? SearchParishioner(int id)
            {
                return Array.Find(parishionerArray, p => p.ID.Equals(id));//metodo para filtrar un feligrense por su id
            }
            public bool UpdateParishioner(Parishioner? parishioner)
            {
                if (parishioner == null) return false;
                var index = Array.FindIndex(parishionerArray, p => p.ID.Equals(parishioner?.ID) == true);//Recibe el nuevo objeto con la informacion actualizada y se guarda en la misma posicion
                if (index < 0) return false;
                parishionerArray[index] = parishioner;
                return true;
            }
        }
    }
