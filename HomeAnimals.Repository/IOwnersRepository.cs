using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeAnimals.Repository
{
    public interface IOwnersRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<Tuple<bool, string, List<OwnerDetails>>> GetAllOwners();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Tuple<bool, string, OwnerDetails>> GetOwnersById(string Id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateNoOfFeeding"></param>
        /// <returns></returns>
        Task<Tuple<bool, string, OwnerDetails>> UpdateNoOfFeeding(UpdateNoOfFeeding updateNoOfFeeding);
    }
}
