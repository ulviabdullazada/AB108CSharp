using AB108;

namespace AccessModifier2CL
{
    class Student
    {
        //private int _code;
        //public int Code 
        //{ 
        //    set
        //    {
        //        _code = value * 2;
        //    } 
        //}
        //public int Code { get 
        //    {
        //        return 0;
        //    } 
        //    init
        //    {

        //    }
        //}
        //readonly -> yalniz default qiymet verilende ve ya ctor daxilinde qiymeti deyisile biler
        //init (as prop) -> default qiymet, ctor daxil edilende ve object initalize zamani deyisilir (scope daxilinde)
        public readonly int Code = 5;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(int code)
        {
            Code = code;
        }
        
    }
}
