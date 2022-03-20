namespace MyLinq;

public class LinqShow
{
    public void Show()
    {
        List<Student> studentList = new List<Student>();

        {
            var result = studentList.ElevenWhere(s => s.Age < 30);
        }
        {
        }
    }

    #region 数据准备

    private List<Student> GetStudentList()
    {
        #region 初始化数据

        List<Student> studentList = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "1",
                ClassId = 2,
                Age = 35
            },
            new Student()
            {
                Id = 1,
                Name = "2",
                ClassId = 2,
                Age = 23
            },
            new Student()
            {
                Id = 1,
                Name = "3",
                ClassId = 2,
                Age = 27
            },
            new Student()
            {
                Id = 1,
                Name = "4",
                ClassId = 2,
                Age = 26
            },
            new Student()
            {
                Id = 1,
                Name = "5",
                ClassId = 2,
                Age = 25
            },
            new Student()
            {
                Id = 1,
                Name = "6",
                ClassId = 2,
                Age = 24
            },
            new Student()
            {
                Id = 1,
                Name = "7",
                ClassId = 2,
                Age = 22
            },
            new Student()
            {
                Id = 1,
                Name = "8",
                ClassId = 2,
                Age = 34
            },
            new Student()
            {
                Id = 1,
                Name = "9",
                ClassId = 2,
                Age = 30
            },
            new Student()
            {
                Id = 1,
                Name = "9",
                ClassId = 2,
                Age = 30
            },
            new Student()
            {
                Id = 1,
                Name = "10",
                ClassId = 2,
                Age = 30
            }
        };

        #endregion 初始化数据

        return studentList;
    }

    #endregion 数据准备
}