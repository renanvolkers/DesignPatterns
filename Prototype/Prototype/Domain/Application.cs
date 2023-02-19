
namespace Prototype.Domain
{
    public static class  Application
    {
        public static List<IStaff> FilterStaff(TypeEmployee typeEmployee, List<IStaff> staff)
        {
            var filterStaff = new List<IStaff>();   
            if (typeEmployee == TypeEmployee.EngineerSoftware)
            {
                filterStaff = staff.Where(x => x.GetType() == typeof(EngineerSoftware)).ToList();
            }
            if (typeEmployee == TypeEmployee.Typist)
            {
                filterStaff = staff.Where(x => x.GetType() == typeof(Typist)).ToList();
            }
            return filterStaff;
        }
        public static List<IStaff> DeepClone(TypeEmployee typeEmployee, List<IStaff> staff)
        {
            var filterStaff = new List<IStaff>();
            if (typeEmployee == TypeEmployee.EngineerSoftware)
            {
                staff.Where(x => x.GetType() == typeof(EngineerSoftware)).ToList()
                    .ForEach(x => {
                        filterStaff.Add(x.DeepClone()); 
                    });
            }
            if (typeEmployee == TypeEmployee.Typist)
            {
                staff.Where(x => x.GetType() == typeof(Typist)).ToList()
                    .ForEach(x => {
                        filterStaff.Add(x.DeepClone());
                    });

            }
            return filterStaff;
        }
        public static List<IStaff> ShallowClone(TypeEmployee typeEmployee, List<IStaff> staff)
        {
            var filterStaff = new List<IStaff>();
            if (typeEmployee == TypeEmployee.EngineerSoftware)
            {
                staff.Where(x => x.GetType() == typeof(EngineerSoftware)).ToList()
                    .ForEach(x => {
                        filterStaff.Add(x.ShallowClone());
                    });
            }
            if (typeEmployee == TypeEmployee.Typist)
            {
                staff.Where(x => x.GetType() == typeof(Typist)).ToList()
                    .ForEach(x => {
                        filterStaff.Add(x.ShallowClone());
                    });

            }
            return filterStaff;
        }
    }
}
