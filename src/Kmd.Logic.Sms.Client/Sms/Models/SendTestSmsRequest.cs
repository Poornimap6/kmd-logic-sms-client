// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Sms.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendTestSmsRequest
    {
        /// <summary>
        /// Initializes a new instance of the SendTestSmsRequest class.
        /// </summary>
        public SendTestSmsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendTestSmsRequest class.
        /// </summary>
        /// <param name="toPhoneNumber">The phone number of recipient of the
        /// test SMS in E.164 format. Example: +4537360734</param>
        /// <param name="body">The text of the SMS message</param>
        public SendTestSmsRequest(string toPhoneNumber, string body)
        {
            ToPhoneNumber = toPhoneNumber;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the phone number of recipient of the test SMS in E.164
        /// format. Example: +4537360734
        /// </summary>
        [JsonProperty(PropertyName = "toPhoneNumber")]
        public string ToPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the text of the SMS message
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ToPhoneNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ToPhoneNumber");
            }
            if (Body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Body");
            }
        }
    }
}
