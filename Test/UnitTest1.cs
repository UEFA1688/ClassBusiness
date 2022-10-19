using System.Linq;
namespace Test;

public class UnitTest1
{
    // ทดสอบเข้าเมนู หลัก
    [Fact]
    public void TestEntryReservation()
    {
        MainMenu menu = new MainMenu();
        Assert.Equal(menu.check1(),"menu");
    }

}