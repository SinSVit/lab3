namespace LabTwo.Warnings
{
    public interface IWarning
    {
        string Text { get; }
    }
    public class IncorrectUniversityName : IWarning
    {
        public IncorrectUniversityName() { Text = "Ім'я університету не може бути пустим та повинно мати букви"; }

        public string Text { get; private set; }
    }
    public class IncorrectFoundationYear : IWarning
    {
        public IncorrectFoundationYear() { Text = "Рік заснування не повинен бути меньше 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectRank : IWarning
    {
        public IncorrectRank() { Text = "Рейтинг повинен бути від 0 до 100"; }

        public string Text { get; private set; }
    }
    public class IncorrectDepartmentName : IWarning
    {
        public IncorrectDepartmentName() { Text = "Назва факультету не може бути пустою та повинна мати букви"; }

        public string Text { get; private set; }
    }
    public class IncorrectDeaneryCabinetNumber : IWarning
    {
        public IncorrectDeaneryCabinetNumber() { Text = "Номер кабінету повинен бути більше 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectSubjectName : IWarning
    {
        public IncorrectSubjectName() { Text = "Назва дисциплін не може бути пустою та повинна мати букви"; }

        public string Text { get; private set; }
    }
    public class IncorrectSubjectCredit : IWarning
    {
        public IncorrectSubjectCredit() { Text = "Кількість кредитів за предмет повинно бути більше 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectPersonName : IWarning
    {
        public IncorrectPersonName() { Text = "ПІБ не може бути пустим або мати цифри"; }

        public string Text { get; private set; }
    }
    public class IncorrectPersonAge : IWarning
    {
        public IncorrectPersonAge() { Text = "Вік повинен бути від 0 до 150"; }

        public string Text { get; private set; }
    }
    public class IncorrectRecordBookNumber : IWarning
    {
        public IncorrectRecordBookNumber() { Text = "Записник може містити лише цифри"; }

        public string Text { get; private set; }
    }
    public class IncorrectYearInUniversity : IWarning
    {
        public IncorrectYearInUniversity() { Text = "Роки в університеті можуть бути від 1 до 6"; }

        public string Text { get; private set; }
    }
    public class IncorrectAuditoriumName : IWarning
    {
        public IncorrectAuditoriumName() { Text = "Аудитория не може бути пустою"; }

        public string Text { get; private set; }
    }
    public class IncorrectCapacity : IWarning
    {
        public IncorrectCapacity() { Text = "Місткість аудиторій повинна бути більше 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectNumberOfRowsInAuditorium : IWarning
    {
        public IncorrectNumberOfRowsInAuditorium() { Text = "Кількість рядів в аудиторії повинно бути більше 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectNumberOfDevicesInAuditorium : IWarning
    {
        public IncorrectNumberOfDevicesInAuditorium() { Text = "Кількість пристроїв в аудиторії повинно бути більше 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectPassport : IWarning
    {
        public IncorrectPassport() { Text = "Приклад номера паспорта: АА123456"; }

        public string Text { get; private set; }
    }
    public class PassportAlreadyExists : IWarning
    {
        public PassportAlreadyExists() { Text = "Такий паспорт вже є"; }

        public string Text { get; private set; }
    }
    public class IncorrectYearsWorking : IWarning
    {
        public IncorrectYearsWorking() { Text = "Кільсть років праці повинно бути більше ніж 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectEngineersForAuditorium : IWarning
    {
        public IncorrectEngineersForAuditorium() { Text = "Максимальна кількість інженерів на одну аудиторію - 2"; }

        public string Text { get; private set; }
    }
    public class IncorrectStudentsForTeacher : IWarning
    {
        public IncorrectStudentsForTeacher() { Text = "Максимальна кількість студентів на одного викладача - 10"; }

        public string Text { get; private set; }
    }
    public class UniversityToCombineNotChosen : IWarning
    {
        public UniversityToCombineNotChosen() { Text = "Ви не обрали університет для об'єднання"; }

        public string Text { get; private set; }
    }
    public class DepartmentNotChosen : IWarning
    {
        public DepartmentNotChosen() { Text = "Ви не обрали факультет"; }

        public string Text { get; private set; }
    }
    public class TeacherNotChosen : IWarning
    {
        public TeacherNotChosen() { Text = "Ви не обрали викладча"; }

        public string Text { get; private set; }
    }
    public class UniversityNotChosen : IWarning
    {
        public UniversityNotChosen() { Text = "Ви не обрали університет"; }

        public string Text { get; private set; }
    }
    public class IncorrectWifiSpeed : IWarning
    {
        public IncorrectWifiSpeed() { Text = "Швидкість Wifi повинна бути більше ніж 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectNumberOfSubjects : IWarning
    {
        public IncorrectNumberOfSubjects() { Text = "Кількість дисциплін повинна бути більше ніж 0"; }

        public string Text { get; private set; }
    }
    public class IncorrectNumberOfScientificWorks : IWarning
    {
        public IncorrectNumberOfScientificWorks() { Text = "Кількість науковців повинна бути більше ніж 0"; }

        public string Text { get; private set; }
    }
    public class AuditoriumNotChosen : IWarning
    {
        public AuditoriumNotChosen() { Text = "Аудиторія не обрана"; }

        public string Text { get; private set; }
    }
    public class NoWorkerWithSuchPassport : IWarning
    {
        public NoWorkerWithSuchPassport() { Text = "Працівника з цим номером паспорта не знайдено"; }

        public string Text { get; private set; }
    }
}