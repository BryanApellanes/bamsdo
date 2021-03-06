using Bam.Net.Schema.Org.DataTypes;

namespace Bam.Net.Schema.Org.Things
{
	///<summary>A delivery service through which content is provided via broadcast over the air or online.</summary>
	public class BroadcastService: Service
	{
		///<summary>The media network(s) whose content is broadcast on this station.</summary>
		public Organization BroadcastAffiliateOf {get; set;}
		///<summary>The name displayed in the channel guide. For many US affiliates, it is the network name.</summary>
		public Text BroadcastDisplayName {get; set;}
		///<summary>The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".</summary>
		public OneOfThese<BroadcastFrequencySpecification,Text> BroadcastFrequency {get; set;}
		///<summary>The timezone in ISO 8601 format for which the service bases its broadcasts</summary>
		public Text BroadcastTimezone {get; set;}
		///<summary>The organization owning or operating the broadcast service.</summary>
		public Organization Broadcaster {get; set;}
		///<summary>A broadcast channel of a broadcast service. Inverse property: providesBroadcastService.</summary>
		public BroadcastChannel HasBroadcastChannel {get; set;}
		///<summary>A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.</summary>
		public BroadcastService ParentService {get; set;}
		///<summary>The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).</summary>
		public Text VideoFormat {get; set;}
	}
}
