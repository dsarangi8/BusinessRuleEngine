using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Payments : IRules
    {

        public paymentType pType { get; set; }
        public string setRules(paymentType type)
        {
            try
            {
                switch (pType)
                {
                    case paymentType.book when pType == paymentType.physicalProduct:
                        return "Generate a commission payment to agent.";
                    case paymentType.membership when pType == paymentType.upgrade:
                        return "Send email for activate/upgrade.";
                    case paymentType.physicalProduct:
                        return "Generate a paking slip for shipping.";
                    case paymentType.book:
                        return "Create a duplicate paking slip for royalty department.";
                    case paymentType.membership:
                        return "Activate the member.";
                    case paymentType.upgrade:
                        return "Upgrade the member.";
                    case paymentType.video:
                        return "Add a free video to the parking slip.";
                    default:
                        return string.Empty;
                }
            }
            catch (Exception exception)
            {
                return exception.Message.ToString();
            }
        }
    }

    public enum paymentType
    {
        physicalProduct,
        book,
        membership,
        upgrade,
        video,
    }
}
