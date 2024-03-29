using Bam.Net.Schema.Org.DataTypes;

namespace Bam.Net.Schema.Org.Things
{
	///<summary>A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.</summary>
	public class DietarySupplement: Substance
	{
		///<summary>An active ingredient, typically chemical compounds and/or biologic substances.</summary>
		public new Text ActiveIngredient {get; set;}
		///<summary>Descriptive information establishing a historical perspective on the supplement. May include the rationale for the name, the population where the supplement first came to prominence, etc.</summary>
		public Text Background {get; set;}
		///<summary>True if this item's name is a proprietary/brand name (vs. generic name).</summary>
		public Boolean IsProprietary {get; set;}
		///<summary>The drug or supplement's legal status, including any controlled substance schedules that apply.</summary>
		public new OneOfThese<DrugLegalStatus,MedicalEnumeration,Text> LegalStatus {get; set;}
		///<summary>The manufacturer of the product.</summary>
		public Organization Manufacturer {get; set;}
		///<summary>Recommended intake of this supplement for a given population as defined by a specific recommending authority.</summary>
		public new MaximumDoseSchedule MaximumIntake {get; set;}
		///<summary>The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.</summary>
		public Text MechanismOfAction {get; set;}
		///<summary>The generic name of this drug or supplement.</summary>
		public Text NonProprietaryName {get; set;}
		///<summary>Proprietary name given to the diet plan, typically by its originator or creator.</summary>
		public Text ProprietaryName {get; set;}
		///<summary>Recommended intake of this supplement for a given population as defined by a specific recommending authority.</summary>
		public RecommendedDoseSchedule RecommendedIntake {get; set;}
		///<summary>Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.</summary>
		public Text SafetyConsideration {get; set;}
		///<summary>Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.</summary>
		public Text TargetPopulation {get; set;}
	}
}
