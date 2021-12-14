using HomeAnimals.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAnimals.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OwnerController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger<OwnerController> _logger;
        /// <summary>
        /// 
        /// </summary>
        private readonly IOwnersRepository _ownersRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="homeAnimalsDbContext"></param>
        /// <param name="OwnersRepository"></param>
        public OwnerController(ILogger<OwnerController> logger, IOwnersRepository OwnersRepository)
        {
            _logger = logger;
            _ownersRepository = OwnersRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<OwnerDetails> GetOwnersById(string Id)
        {
            Tuple<bool, string, OwnerDetails> tuple = await _ownersRepository.GetOwnersById(Id);
            return tuple.Item3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<OwnerDetails>> GetAllOwners()
        {
            Tuple<bool, string, List<OwnerDetails>> tuple = await _ownersRepository.GetAllOwners();
            return tuple.Item3;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateNoOfFeeding"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<OwnerDetails> UpdateNoOfFeeding(UpdateNoOfFeeding updateNoOfFeeding)
        {
            Tuple<bool, string, OwnerDetails> tuple = await _ownersRepository.UpdateNoOfFeeding(updateNoOfFeeding);
            return tuple.Item3;
        }
    }
}
