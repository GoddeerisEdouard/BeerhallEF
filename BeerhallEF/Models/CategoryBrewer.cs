using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    public class CategoryBrewer
    {
        #region Properties
        public int BrewerId { get; set; }
        public int  CategoryId { get; set; }
        #endregion

        #region Navigational Properties 
        public Brewer Brewer { get; set; }
        public Category Category { get; set; }
        #endregion

        #region Constructors
        protected CategoryBrewer()
        {
        }

        public CategoryBrewer(Category category, Brewer brewer) : this()
        {
            Category = category;
            CategoryId = Category.CategoryId;

            Brewer = brewer;
            BrewerId = Brewer.BrewerId;
        }
        #endregion
    }
}
