using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundLib
{
    public class PlayGroundsRepository
    {
        private int _nextId = 5;
        private List<PlayGround> _playGrounds = new List<PlayGround>
        {
            new PlayGround { Id = 1, Name = "Millpark", MaxChildren = 10, MinChildAge = 5 },
            new PlayGround { Id = 2, Name = "Secret Playground", MaxChildren = 12, MinChildAge = 4 },
            new PlayGround { Id = 3, Name = "Library", MaxChildren = 8, MinChildAge = 3 },
            new PlayGround { Id = 4, Name = "School", MaxChildren = 15, MinChildAge = 7 },
        };
        //public List<PlayGroundLib> GetAll(string? name = null, int? maxChildren = 0, int? minAge = 0)
        //{
        //    return _playGrounds;
        //}
        public IEnumerable<PlayGround> GetAll(string? name = null, int maxChildren = 0, int minChildAge = 0)
        {
            return _playGrounds;
        }
        public PlayGround? GetById(int id)
        {
            return _playGrounds.FirstOrDefault(p => p.Id == id);
        }
        public PlayGround Add(PlayGround playGround)
        {
            playGround.Id = _nextId++;
            _playGrounds.Add(playGround);
            return playGround;
        }
        public PlayGround? Update(int id, PlayGround updatedPlayGround)
        {
            PlayGround? existingPlayGround = _playGrounds.FirstOrDefault(p => p.Id == id);
            if (existingPlayGround == null)
            {
                return null;
            }

            // Update fields of the existing playground
            existingPlayGround.Name = updatedPlayGround.Name;
            existingPlayGround.MaxChildren = updatedPlayGround.MaxChildren;
            existingPlayGround.MinChildAge = updatedPlayGround.MinChildAge;

            return existingPlayGround;
        }

    }
}
