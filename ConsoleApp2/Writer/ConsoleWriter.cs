using System;
using Lab_Tracer.Serilization;


namespace Lab_Tracer
    {
        namespace Writer
        {
            public class ConsoleWriter : IWriter
            {
                public void Write(ISerializer serializer, TraceResult traceResult)
                {
                    Console.WriteLine(serializer.Serialize(traceResult));
                }
            }
        }
    }
