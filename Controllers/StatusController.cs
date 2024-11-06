using dharmendraPradhan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace dharmendraPradhan.Controllers
{
    [Route("api/Status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly CommunityDominatesContext _communityContext;
        private readonly PartyConditionContext _partyConditionContext;
        private readonly StatusDevelopmentWorkContext _developmentWorkContext;
        private readonly StatusResultsContext _resultsContext;
        private readonly StatusPoliticalNoteContext _politicalNoteContext;
        private readonly StatusPanchayatMembersContext _panchayatMembersContext;
        private readonly StatusMainWorkerContext _mainWorkerContext;
        private readonly StatusMainLocalDemandContext _localDemandContext;
        private readonly StatusLocalShopKeeperContext _localShopKeeperContext;
        private readonly StatusGovtOfficialsWorkingContext _govtOfficialsContext;
        private readonly StatusImportantGroupsContext _importantGroupsContext;
        private readonly StatusLocalPeopleContext _localPeopleContext;
        private readonly StatusSocialMediaActContext _socialMediaActContext;
        private readonly StatusContactPersonContext _contactPersonContext;
        private readonly StatusBoothAgentContext _boothAgentContext;
        private readonly StatusAreaDevelopContext _areaDevelopContext;
        private readonly StatusCommunityPeopleContext _communityPeopleContext;
        private readonly StatusGetAllLocsContext _getAllLocsContext;




        public StatusController(
            CommunityDominatesContext communityContext,
            PartyConditionContext partyConditionContext,
            StatusDevelopmentWorkContext developmentWorkContext,
            StatusResultsContext resultsContext,
            StatusPoliticalNoteContext politicalNoteContext,
            StatusPanchayatMembersContext panchayatMembersContext,
            StatusMainWorkerContext mainWorkerContext,
            StatusMainLocalDemandContext localDemandContext,
            StatusLocalShopKeeperContext localShopKeeperContext,
            StatusGovtOfficialsWorkingContext govtOfficialsContext,
            StatusImportantGroupsContext importantGroupsContext,
            StatusLocalPeopleContext localPeopleContext,
            StatusSocialMediaActContext socialMediaActContext,
            StatusContactPersonContext contactPersonContext,
            StatusBoothAgentContext boothAgentContext,
            StatusAreaDevelopContext areaDevelopContext,
            StatusCommunityPeopleContext communityPeopleContext,
                        StatusGetAllLocsContext getAllLocsContext)


        {
            _communityContext = communityContext;
            _partyConditionContext = partyConditionContext;
            _developmentWorkContext = developmentWorkContext;
            _resultsContext = resultsContext;
            _politicalNoteContext = politicalNoteContext;
            _panchayatMembersContext = panchayatMembersContext;
            _mainWorkerContext = mainWorkerContext;
            _localDemandContext = localDemandContext;
            _localShopKeeperContext = localShopKeeperContext;
            _govtOfficialsContext = govtOfficialsContext;
            _importantGroupsContext = importantGroupsContext;
            _localPeopleContext = localPeopleContext;
            _socialMediaActContext = socialMediaActContext;
            _contactPersonContext = contactPersonContext;
            _boothAgentContext = boothAgentContext;
            _areaDevelopContext = areaDevelopContext;
            _communityPeopleContext = communityPeopleContext;
            _getAllLocsContext = getAllLocsContext;  

        }

        // Get Community Dominates Data
        [HttpGet("community-dominates/{Loc_ID}")]
        public async Task<IActionResult> GetDominatesData(string Loc_ID)
        {
            var result = await _communityContext.CommunityDominates
                                        .Where(l => l.Loc_Id == Loc_ID)
                                        .Select(l => new
                                        {
                                            l.AC_Name,
                                            l.Village_Name
                                        })
                                        .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No community dominates data found.");
        }

        // Get Party Condition Data
        [HttpGet("party-condition/{Loc_ID}")]
        public async Task<IActionResult> GetPartyCondition(string Loc_ID)
        {
            var result = await _partyConditionContext.PartyCondition
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new { l.BJP, l.BJD, l.INC, l.Others })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No party condition data found.");
        }

        // Get Development Work Data
        [HttpGet("development-work/{Loc_ID}")]
        public async Task<IActionResult> GetDevelopmentWork(string Loc_ID)
        {
            var result = await _developmentWorkContext.StatusDevelopmentWork
                        .Where(l => l.Loc_ID == Loc_ID)
                        .Select(l => new { l.MLA_Work_Done })
                        .ToListAsync();

            return Ok(result);
        }

        // Get Results Data
        [HttpGet("results/{Loc_ID}")]
        public async Task<IActionResult> GetResults(string Loc_ID)
        {
            var result = await _resultsContext.StatusResults
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new { l.BJP, l.BJD, l.INC, l.OTH, l.Total })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No results found.");
        }

        // Get Political Note Data
        [HttpGet("political-note/{Loc_ID}")]
        public async Task<IActionResult> GetPoliticalNote(string Loc_ID)
        {
            var result = await _politicalNoteContext.StatusPoliticalNote
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => l.Position)
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No political notes found.");
        }

        // Get Panchayat Members Data
        [HttpGet("panchayat-members/{Loc_ID}")]
        public async Task<IActionResult> GetPanchayatMembers(string Loc_ID)
        {
            var result = await _panchayatMembersContext.StatusPanchayatMember
                .Where(l => l.Loc_ID == Loc_ID)
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No panchayat members found.");
        }

        // Get Main Workers Data
        [HttpGet("main-workers/{Loc_ID}")]
        public async Task<IActionResult> GetMainWorkers(string Loc_ID)
        {
            var result = await _mainWorkerContext.StatusMainWorkers
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Party,
                    l.Age,
                    l.Communtiy,
                    l.Worker_Name,
                    l.Gender,
                    l.Mobile,
                    l.Effect
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No main workers found.");
        }

        // Get Local Demands Data
        [HttpGet("local-demands/{Loc_ID}")]
        public async Task<IActionResult> GetLocalDemands(string Loc_ID)
        {
            var result = await _localDemandContext.StatusMainLocalDemand
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => l.Main_Needs_of_People)
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No local demands found.");
        }

        // Get Local Shop Keepers Data
        [HttpGet("local-shop-keepers/{Loc_ID}")]
        public async Task<IActionResult> GetLocalShopKeepers(string Loc_ID)
        {
            var result = await _localShopKeeperContext.StatusLocalShopKeepers
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Person_Name,
                    l.Community,
                    l.Mobile
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No local shop keepers found.");
        }

        // Get Government Officials Working Data
        [HttpGet("govt-officials/{Loc_ID}")]
        public async Task<IActionResult> GetGovtOfficialsWorking(string Loc_ID)
        {
            var result = await _govtOfficialsContext.StatusGovtOfficialsWorking
                        .Where(l => l.Loc_ID == Loc_ID)
                        .Select(l => new
                        {
                            l.Designation,
                            l.Worker_Name,
                            l.Gender,
                            l.Age,
                            l.Community,
                            l.Mobile
                        })
                        .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No records found for the given Loc_ID in Government Officials.");
        }

        // Get Important Groups Data
        [HttpGet("important-groups/{Loc_ID}")]
        public async Task<IActionResult> GetImportantGroups(string Loc_ID)
        {
            var result = await _importantGroupsContext.StatusImportantGroups
                         .Where(l => l.Loc_ID == Loc_ID)
                         .Select(l => new
                         {
                             l.P_Name,
                             l.P_Party,
                             l.P_Mobile,
                             l.P_Community
                         })
                         .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No records found for the given Loc_ID in Important Groups.");
        }

        // Get Local People Data
        [HttpGet("local-people/{Loc_ID}")]
        public async Task<IActionResult> GetLocalPeople(string Loc_ID)
        {
            var result = await _localPeopleContext.StatusLocalPeople
                        .Where(l => l.Loc_ID == Loc_ID)
                        .Select(l => new
                        {
                            l.Worker_Name,
                            l.Community,
                            l.Gender,
                            l.Age,
                            l.Mobile
                        })
                        .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No records found for the given Loc_ID in Local People.");
        }


        // Get Social Media Activist Data
        [HttpGet("social-media-activist/{Loc_ID}")]
        public async Task<IActionResult> GetSocialMediaActivist(string Loc_ID)
        {
            var result = await _socialMediaActContext.SocialMediaActivist
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Gender,
                    l.Age,
                    l.Community,
                    l.Mobile,
                    l.Worker_Name
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound("No social media activists found.");
        }


        [HttpGet("contact-person/{Loc_ID}")]
        public async Task<IActionResult> GetContactPerson(string Loc_ID)
        {
            var result = await _contactPersonContext.StatusContactPerson
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Person_Name,
                    l.Community,
                    l.Mobile
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound(new { message = "No records found for the given Loc_ID" });
        }


        [HttpGet("booth-agent/{Loc_ID}")]
        public async Task<IActionResult> GetStatusBoothAgent(string Loc_ID)
        {
            var result = await _boothAgentContext.StatusBoothAgents
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Gender,
                    l.Booth_Agent_Name,
                    l.Booth_no_Agent,
                    l.Community,
                    l.Age,
                    l.Mobile,
                    l.Party
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound(new { message = "No records found for the given Loc_ID" });
        }


        [HttpGet("area-develop/{Loc_ID}")]
        public async Task<IActionResult> GetAreaDevelop(string Loc_ID)
        {
            var result = await _areaDevelopContext.StatusAreaDevelops
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Area,
                    l.Date_of_Update
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound(new { message = "No records found for the given Loc_ID" });
        }


        // Get Community People Data
        [HttpGet("community-people/{Loc_ID}")]
        public async Task<IActionResult> GetCommunityPeople(string Loc_ID)
        {
            var result = await _communityPeopleContext.StatusCommunityPeople
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.Community,
                    l.Category,
                    l.Vote,
                    l.Party_3,
                    l.Party_2,
                    l.Party,
                    l.Imp_Name_1,
                    l.Imp_Name_2,
                    l.Imp_Name_3,
                    l.Imp_Mobile_1,
                    l.Imp_Mobile_2,
                    l.Imp_Mobile_3
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound(new { message = "No records found for the given Loc_ID" });
        }



        [HttpGet("all-locs")]
        public async Task<IActionResult> GetAllLocs()
        {
            var result = await _getAllLocsContext.StatusGetAllLocs
                .Select(l => new
                {
                    l.AC_Name,
                    l.Village_Name,
                    l.Loc_ID
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound(new { message = "No records found" });
        }

        // Get location by Loc_ID
        [HttpGet("all-locs/{Loc_ID}")]
        public async Task<IActionResult> GetAllLocsById(string Loc_ID)
        {
            var result = await _getAllLocsContext.StatusGetAllLocs
                .Where(l => l.Loc_ID == Loc_ID)
                .Select(l => new
                {
                    l.AC_Name,
                    l.Village_Name
                })
                .ToListAsync();

            return result.Any() ? Ok(result) : NotFound(new { message = "No records found for the given Loc_ID" });
        }
    }
}
