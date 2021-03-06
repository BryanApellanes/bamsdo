using Bam.Net.Schema.Org.DataTypes;

namespace Bam.Net.Schema.Org.Things
{
	///<summary>The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.</summary>
	public class CommunicateAction: InteractAction
	{
		///<summary>The subject matter of the content. Inverse property: subjectOf.</summary>
		public Thing About {get; set;}
		///<summary>The language of the content or performance or used in an action. Please use one of the language codes from the IETF BCP 47 standard. See also availableLanguage. Supersedes language.</summary>
		public OneOfThese<Language,Text> InLanguage {get; set;}
		///<summary>A sub property of participant. The participant who is at the receiving end of the action.</summary>
		public OneOfThese<Audience,ContactPoint,Organization,Person> Recipient {get; set;}
	}
}
