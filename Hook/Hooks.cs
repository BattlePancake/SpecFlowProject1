using SpecFlowProject1.Factory;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class Hooks
    {
        [AfterScenario("TearDown")]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
