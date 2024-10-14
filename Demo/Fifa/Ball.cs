using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }

		private Location location;

		public Location Location
		{
			get { return location; }
			// event
            set 
            {

                if (!value.Equals(location))
                { // if the new value is different from the old value
                  // notify subscribers [referees, players, etc] about the change
                  
                    location = value;

                    BallLocationChange?.Invoke();
                }
            }
		}

        
        public event Action? BallLocationChange;

        public override string ToString()
        {
            return $"Id: {Id}, Location: {Location}";
        }

    }
}
