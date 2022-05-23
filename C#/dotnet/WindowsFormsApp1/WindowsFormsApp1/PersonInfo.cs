using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PersonInfo<T>//泛型未定資料型態打大寫 T
    {
        public T data;
        public void SaveData(T inputData)
        {
            data = inputData;
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.String:
                    Console.WriteLine("string型態");                   
                    break;
                case TypeCode.Int32:
                    Console.WriteLine("Int32型態");                   
                    break;
                case TypeCode.Double:
                    Console.WriteLine("double型態");                   
                    break;
                case TypeCode.Boolean:
                    Console.WriteLine("bool型態");                   
                    break;
                default:
                    Console.WriteLine("其他資料型態");
                    break;
            }
        }

    }
}
