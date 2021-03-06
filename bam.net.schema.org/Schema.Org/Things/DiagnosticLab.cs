using Bam.Net.Schema.Org.DataTypes;

namespace Bam.Net.Schema.Org.Things
{
	///<summary>A medical laboratory that offers on-site or off-site diagnostic services.</summary>
	public class DiagnosticLab: MedicalOrganization
	{
		///<summary>A diagnostic test or procedure offered by this lab.</summary>
		public MedicalTest AvailableTest {get; set;}
	}
}
