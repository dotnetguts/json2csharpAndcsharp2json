using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JsonPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myJsonArrayString = @"[{'PhotoName':'pic1.png','IsModerated':'true'},{ 'PhotoName':'pic2.jpg','IsModerated':'true'}]";
            string myJsonString = @"{'PhotoName':'mypic.jpg','IsModerated':'false'}";

            //From Json String to C# Object
            MemberPics cSharpObj = JsonConvert.DeserializeObject<MemberPics>(myJsonString);
            List<MemberPics> cSharpObjList = JsonConvert.DeserializeObject<List<MemberPics>>(myJsonArrayString);

            Console.WriteLine("Photo Name: " + cSharpObj.PhotoName + ",  IsModerated: " + cSharpObj.IsModerated);

            foreach (var item in cSharpObjList)
            {
                Console.WriteLine("Photo Name: " + item.PhotoName + ",  IsModerated: " + item.IsModerated);
            }


            //From C# Object to Json String
            string jsonString = JsonConvert.SerializeObject(cSharpObj, Formatting.Indented);
            Console.WriteLine(jsonString);
            string jsonArrayString = JsonConvert.SerializeObject(cSharpObjList, Formatting.Indented);
            Console.WriteLine(jsonArrayString);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }

    class MemberPics
    {
        public string PhotoName { get; set; }
        public bool IsModerated { get; set; }
    }
}
