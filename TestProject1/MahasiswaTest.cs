using NUnit.Framework;
using TUBES_KPL_NONGUI;

namespace TUBES_KPL_NONGUI_Test
{
    [TestFixture]
    public class MahasiswaTest
    {
        [Test]
        public void TestMahasiswaProperties()
        {
            // Arrange
            string expectedNama = "John Doe";
            int expectedKehadiran = 5;

            // Act
            Mahasiswa mahasiswa = new Mahasiswa
            {
                Nama = expectedNama,
                Kehadiran = expectedKehadiran
            };

            // Assert
            Assert.AreEqual(expectedNama, mahasiswa.Nama);
            Assert.AreEqual(expectedKehadiran, mahasiswa.Kehadiran);
        }
    }
}
