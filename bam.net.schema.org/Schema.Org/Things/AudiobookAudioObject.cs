using Bam.Net.Schema.Org.DataTypes;

namespace Bam.Net.Schema.Org.Things
{
	///<summary>An audiobook.</summary>
	public class AudiobookAudioObject: AudioObject
	{
		///<summary>The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.</summary>
		public new Duration Duration {get; set;}
		///<summary>A person who reads (performs) the audiobook.</summary>
		public Person ReadBy {get; set;}
	}
}
