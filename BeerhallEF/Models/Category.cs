using System.Collections.Generic;
using System.Linq;

namespace BeerhallEF.Models
{
    public class Category
    {
        #region Properties
        public int CategoryId { get; private set; }
        public string Name { get; set; }
        #endregion

        #region Collections
        public ICollection<CategoryBrewer> CategoryBrewers { get; private set; }
        public IEnumerable<Brewer> Brewers => CategoryBrewers.Select(b => b.Brewer);
        #endregion

        #region Constructors
        protected Category()
        {
            CategoryBrewers = new HashSet<CategoryBrewer>();
        }

        public Category(string name) : this()
        {
            Name = name;
        }
        #endregion

        #region Public Functions
        public void Add(Brewer b)
        {
            CategoryBrewers.Add(new CategoryBrewer(this, b));
        }
        #endregion
    }
}