using SpecFlowWorkshop.Models;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowWorkshop.StepDefinitions
{
    [Binding]
    public class UsingSpecFlowAssistStepDefinitions
    {
        private Album myAlbum = new Album();

        [Given(@"the following album exists")]
        public void GivenTheFollowingAlbumExists(Table table)
        {
        }

        [When(@"the album is rereleased")]
        public void WhenTheAlbumIsRereleased()
        {
            myAlbum.ReleaseYear = DateTime.Now.Year;
        }

        [Then(@"the new album details should be")]
        public void ThenTheNewAlbumDetailsShouldBe(Table table)
        {
        }
    }
}
