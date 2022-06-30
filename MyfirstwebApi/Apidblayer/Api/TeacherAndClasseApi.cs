namespace Apidblayer.Api
{
    public class TeacherAndClasseApi
    {
        public TeacherApi Teacher{ get; set; }

        public ICollection<Classeapi> classe{ get; set; }
    }
}
