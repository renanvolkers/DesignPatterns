using System.IO;
using System;

namespace Builder.Domain { 
public class Application {

        public OperationalSystem MakeOSWindows()
        {
            var director = new Director();
            var builder = new OperationalSystemBuilder();
            director.OperationalSystemWindows(builder);
            return builder.GetOS();
        }

        public OperationalSystem MakeOperationalSystem(TypeOS typeOS )
        {
            var diretor = new Director();
            var builder = new OperationalSystemBuilder();
            if (TypeOS.Windows == typeOS)
            {
                diretor.OperationalSystemWindows(builder);
            }

            if (TypeOS.Linux == typeOS)
            {
                diretor.OperationalSystemLinux(builder);
            }
            return builder.GetOS();
        }

        public Notbook MakeNotbook(TypeHardware typeHardware)
        {
            var director = new Director();
            var builder = new HardwareBuilder();

            if (TypeHardware.Intel == typeHardware)
            {
                director.Buildcomputer(builder);
            }
            director.OperationalSystemLinux(builder);
            return builder.GetNotbook();
        }
    }
}