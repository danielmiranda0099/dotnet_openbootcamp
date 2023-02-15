using API.Models.DataModels;

namespace API.Services;

public class Services {
    //Buscar usuarios por email
    public User GetUserByEmail( string email, IEnumerable<User> users ){
        return users.First( user => user.Email == email );
    }

    //Buscar alumnos mayores de edad
    public IEnumerable<Student> GetStudentsLegalAge( IEnumerable<Student> students ){
        return students.Where( student =>  DateTime.Now.Year - student.Dob.Year >= 18 );
    }

    //Buscar alumnos que tengan al menos un curso
    public IEnumerable<Student> GetStudentsWithCourses( IEnumerable<Student> students ){
        return students.Where( student => student.Courses.Any() );
    }

    //Buscar cursos de un nivel determinado que al menos tengan un alumno inscrito
    public IEnumerable<Course> GetCoursesByLevels(Level level, IEnumerable<Course> courses) {
        return courses.Where( course => course.Level == level && course.Students.Any() );
    }

    //Buscar cursos de un nivel determinado que sean de una categoría determinada
    public IEnumerable<Course> GetCoursesByLevelsAndCategory(Level level, string category, IEnumerable<Course> courses) {
        return courses.Where( course => course.Level == level && course.Categories.Any( categoria => categoria.Name == category));
    }

    //Buscar cursos sin alumnos
    public IEnumerable<Course> GetCoursesWithOutStudents( IEnumerable<Course> courses ){
        return courses.Where( course => !course.Students.Any() );
    }
}