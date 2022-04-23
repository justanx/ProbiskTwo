using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PT_Utility
{
    public static class WC
    {
        public const string ImagePath = @"\images\product_img\";
        public const string SessionCart = "ShoppingCartSession";

        // roles
        public const string AdminRole = "Admin";
        public const string CustomerRole = "Customer";

        public const string EmailAdmin = "lvashy86@gmail.com";


        public const string CategoryName = "Category";
        public const string ApplicationTypeName = "ApplicationType";

        // was set using inquiry or directly without inquiry ?
        public const string SessionInquiryId = "InquirySession";

        // notifications
        public const string Success = "Success";
        public const string Error = "Error";

        // order status 
        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "Processing";
        public const string StatusShipped = "Shipped";
        public const string StatusCanceled = "Cancelled";
        public const string StatusRefunded = "Refunded";



        public static readonly IEnumerable<string> listStatus = new ReadOnlyCollection<string>(
            new List<string>
            {
                StatusApproved,StatusCanceled,StatusInProcess,StatusPending,StatusShipped,StatusRefunded
            }); 
    }
}
