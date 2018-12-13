using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;


namespace Attestation_2.Task_6._13
{
    public class ReflexyUse
    {
        public static List<Type> GetInterfaces(Assembly assembly)
        {
            List<Type> classes = new List<Type>();
            Type[] types = assembly.GetTypes();
            foreach (Type t in types)
            {
                foreach (Type inter in t.GetInterfaces())//правильно работает
                {
                    if (inter.FullName == "ClassLibrary1.IVehicle" && !t.IsAbstract)
                    {
                        //(t.FullName);
                        //comboBox1.Items.Add(t.FullName);
                        classes.Add(t);
                    }
                }
            }
            return classes;
        }

        //public static object GetMethod(object constrclass, MethodInfo method ,object[] parametrs)
        //{
        //    //object classInstance = Activator.CreateInstance(cls, constparametrs);
        //   // MethodInfo method = cls.GetMethod(methodName);
        //    return method.Invoke(constrclass, parametrs);           
        //}

        public static object ConstrClass(Type cls, object[] constparametrs)
        {
            return Activator.CreateInstance(cls, constparametrs);
        }

        public static string[] GetAllProperties(Type cls, object constr)
        {
            PropertyInfo[] pi = cls.GetProperties();
            List<string> answer = new List<string>();
            
            foreach(PropertyInfo p in pi)
            {
                answer.Add(p.Name + " " + p.GetValue(constr));
              
            }
            return answer.ToArray();
        }
    }
}
