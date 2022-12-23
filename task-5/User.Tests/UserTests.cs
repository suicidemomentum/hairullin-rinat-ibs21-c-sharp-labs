using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Exceptions;
using LocalClasses;
using Configs;

namespace UserTests
{
    [TestClass]
    public class UserTests
    {
        private User user;

        [TestInitialize]
        public void Initialize()
        {
            user = new("Login", "John", "Doe");
        }

        [DataTestMethod]
        [DataRow("Login", "John", "Doe", "vakalas@mail.ru", null)]
        [DataRow("Losun", "Jimmy", "Soprano", null, "10.10.2022 0:00:00")]
        [DataRow("Fatpock", "Salvatore", "Maltisanti", "vakalas@mail.ru", "10.10.2022 0:00:00")]
        public void Constructor_SetValidValues_Tests(string login, string firstName, string lastName, string? email, string? birthDate)
        {
            DateTime? birthDateTime = birthDate is not null ? DateTime.Parse(birthDate) : null;

            user = new(login, firstName, lastName, email, birthDateTime);

            Assert.AreEqual(login, user.Login);
            Assert.AreEqual(firstName, user.FirstName);
            Assert.AreEqual(lastName, user.LastName);
            Assert.AreEqual(email, user.Email);
            Assert.AreEqual(birthDateTime, user.BirthDate);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("a@mail.ru")]
        [DataRow("alex@a.ru")]
        [DataRow("alex@aa.ss.dd.ff.gg.hh.jj.kk.ru")]
        public void Email_SetValidValues_Tests(string? target)
        {
            user.Email = target;

            Assert.AreEqual(target, user.Email);
        }

        [DataTestMethod]
        [DataRow("_aa@mail.ru")]
        [DataRow("aa_@mail.ru")]
        [DataRow("aa@.ru")]
        [DataRow("aa@w..ru.")]
        public void Email_SetInvalidValues_ThrowsException_Tests(string target)
        {
            var expected = UserConfig.ErrorStart + UserConfig.EmailFormat;

            var ex = Assert.ThrowsException<UserException>(() => user.Email = target);
            Assert.AreEqual(expected, ex.Message);
        }

        [DataTestMethod]
        [DataRow("Dmitry")]
        [DataRow("Дмитрий")]
        [DataRow("У")]
        [DataRow("V")]
        [DataRow("Лу")]
        [DataRow("Li")]
        [DataRow("Dmitrybigbonghongkongwarrenbuffetcsharpisthebestss")] //50 symbols
        public void FirstName_SetValidValues_Tests(string target)
        {
            user.FirstName = target;

            Assert.AreEqual(target, user.FirstName);
        }

        [DataTestMethod]
        [DataRow("Dmитрий")]
        [DataRow("Dmитрий3")]
        [DataRow("15")]
        [DataRow("дмитрий")]
        [DataRow("dmitryi")]
        [DataRow("dmitryi-олегов")]
        [DataRow("dmitryi-olegov")]
        [DataRow("dmitryi boris")]
        [DataRow("дмитрий борисов")]
        [DataRow("Dmitrybigbonghongkongwarrenbuffetcsharpisthebestssw")] //51 symbols
        public void FirstName_SetInvalidValues_ThrowsException_Tests(string target)
        {
            var expected = UserConfig.ErrorStart + UserConfig.FirstNameFormat;

            var ex = Assert.ThrowsException<UserException>(() => user.FirstName = target);
            Assert.AreEqual(expected, ex.Message);
        }

        [DataTestMethod]
        [DataRow("Жмышенко")]
        [DataRow("Jmichenko")]
        [DataRow("Жмышенко-Альбертович")]
        [DataRow("Jmichenko-Albertovich")]
        [DataRow("Л")]
        [DataRow("V")] //200 symbols down below
        [DataRow("Dmitrybigbonghongkongwarrenbuffetcsharpisthebestsswmitrybigbonghongkongwarrenbuffetcsharpisthebestsmitrybigbonghongkongwarrenbuffetcsharpisthebestsmitrybigbonghongkongwarrenbuffetcsharpisthebestsmarko")]
        public void LastName_SetValidValues_Tests(string target)
        {
            user.LastName = target;

            Assert.AreEqual(target, user.LastName);
        }

        [DataTestMethod]
        [DataRow("Dmитрий")]
        [DataRow("Dmитрий3")]
        [DataRow("15")]
        [DataRow("дмитрий")]
        [DataRow("dmitryi")]
        [DataRow("dmitryi-олегов")]
        [DataRow("Dmitryi-olegov")]
        [DataRow("dmitryi boris")]
        [DataRow("Дмитрий-борисов")] //201 sybmols down below
        [DataRow("Dmitrybigbonghongkongwarrenbuffetcsharpisthebestsswmitrybigbonghongkongwarrenbuffetcsharpisthebestsmitrybigbonghongkongwarrenbuffetcsharpisthebestsmitrybigbonghongkongwarrenbuffetcsharpisthebestsmarkof")]
        public void LastName_SetInvalidValues_ThrowsException_Tests(string target)
        {
            var expected = UserConfig.ErrorStart + UserConfig.LastNameFormat;

            var ex = Assert.ThrowsException<UserException>(() => user.LastName = target);
            Assert.AreEqual(expected, ex.Message);
        }

        [DataTestMethod]
        [DataRow("jmichenko")]
        [DataRow("v")]
        [DataRow("Jmichenkoalbertovich")] //20 symbols
        public void Login_SetValidValues_Tests(string target)
        {
            user.Login = target;

            Assert.AreEqual(target, user.Login);
        }

        [DataTestMethod]
        [DataRow("Дима")]
        [DataRow("Димаalso")]
        [DataRow("Jmichenkoalbertovichs")] //21 symbols
        public void Login_SetInvalidValues_ThrowsException_Tests(string target)
        {
            var expected = UserConfig.ErrorStart + UserConfig.LoginFormat;

            var ex = Assert.ThrowsException<UserException>(() => user.Login = target);
            Assert.AreEqual(expected, ex.Message);
        }

        [TestMethod]
        public void BirthDate_SetNull_Test()
        {
            user.BirthDate = null;

            Assert.AreEqual(null, user.BirthDate);
        }

        [TestMethod]
        public void BirthDate_SetValidDate_Test()
        {
            DateTime date = DateTime.Parse("10-10-2010");

            user.BirthDate = date;

            Assert.AreEqual(date, user.BirthDate);
        }

        [TestMethod]
        public void BirthDate_SetInvalidDate_ThrowsException_Test()
        {
            DateTime date = DateTime.MaxValue;

            var expected = UserConfig.ErrorStart + UserConfig.BirthFormat;

            var ex = Assert.ThrowsException<UserException>(() => user.BirthDate = date);
            Assert.AreEqual(expected, ex.Message);
        }

        [DataTestMethod]
        [DataRow("vakalas@mail.ru", null)]
        [DataRow(null, "10-10-2022")]
        [DataRow("vakalas@mail.ru", "10-10-2022")] //need output as param, not as logic program
        public void Method_ToString_Tests(string? email, string? birthDate)
        {
            DateTime? birthDateTime = birthDate is not null? DateTime.Parse(birthDate): null;
            string output = $"{user.Login}, {user.FirstName}, {user.LastName}, {email}, {birthDate}";

            user.Email = email;
            user.BirthDate = birthDateTime;

            Assert.AreEqual(output, user.ToString());
        }

        [DataTestMethod]
        [DataRow("vakalas@mail.ru", null)]
        [DataRow(null, "10-10-2022")]
        [DataRow("vakalas@mail.ru", "10-10-2022")] //check no ToString, call for object
        public void Method_FillFromString_Tests(string? email, string? birthDate)
        {
            DateTime? birthDateTime = birthDate is not null ? DateTime.Parse(birthDate) : null;

            User temp = new("Temp", "Temp", "Temp");
            temp.FillFromString($"{user.Login}, {user.FirstName}, {user.LastName}, {email}, {birthDate}");

            user.Email = email;
            user.BirthDate = birthDateTime;

            Assert.AreEqual(user.ToString(), temp.ToString());
        }
    }
}