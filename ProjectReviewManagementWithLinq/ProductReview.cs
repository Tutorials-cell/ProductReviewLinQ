using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReviewManagementWithLinq
{
    class ProductReview
    {
        internal bool isLike;

        public int productID { get; set; }
        public string ProductId { get; internal set; }
        public int UserID { get; set; }
        public string UserId { get; internal set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
