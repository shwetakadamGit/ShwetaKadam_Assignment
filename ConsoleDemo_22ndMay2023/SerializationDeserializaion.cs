//using System;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;
//namespace DemoApplication
//{
//    [Serializable]
//    class SeriaClass
//    {
//        public int ID;
//        public String Name;
//        static void Main(string[] args)
//        {
//            //SeriaClass obj = new SeriaClass();
//            //obj.ID = 1;
//            //obj.Name = ".Net";

//            //BinaryFormatter formatter = new BinaryFormatter();
//            //Stream stream = new FileStream(@"C:\\C_SharpTraining\\shwetaFile1.txt", FileMode.OpenOrCreate,FileAccess.Write);

//            //formatter.Serialize(stream, obj);
//            //stream.Close();

//            //stream = new FileStream(@"C:\\C_SharpTraining\\shwetaFile.txt", FileMode.OpenOrCreate, FileAccess.Read);
//            //SeriaClass objnew = (SeriaClass)formatter.Deserialize(stream);

//            //Console.WriteLine(objnew.ID);
//            //Console.WriteLine(objnew.Name);
//            //Console.WriteLine("GC Maximum Generations:" + GC.MaxGeneration);

//            //Console.ReadKey();
//        }
//    }
//}