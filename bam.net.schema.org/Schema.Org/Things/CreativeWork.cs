using Bam.Net.Schema.Org.DataTypes;

namespace Bam.Net.Schema.Org.Things
{
	///<summary>The most generic kind of creative work, including books, movies, photographs, software programs, etc.</summary>
	public class CreativeWork: Thing
	{
		///<summary>The subject matter of the content. Inverse property: subjectOf.</summary>
		public Thing About {get; set;}
		///<summary>The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.</summary>
		public Text AccessMode {get; set;}
		///<summary>A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.</summary>
		public Text AccessModeSufficient {get; set;}
		///<summary>Indicates that the resource is compatible with the referenced accessibility API (WebSchemas wiki lists possible values).</summary>
		public Text AccessibilityAPI {get; set;}
		///<summary>Identifies input methods that are sufficient to fully control the described resource (WebSchemas wiki lists possible values).</summary>
		public Text AccessibilityControl {get; set;}
		///<summary>Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (WebSchemas wiki lists possible values).</summary>
		public Text AccessibilityFeature {get; set;}
		///<summary>A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (WebSchemas wiki lists possible values).</summary>
		public Text AccessibilityHazard {get; set;}
		///<summary>A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."</summary>
		public Text AccessibilitySummary {get; set;}
		///<summary>Specifies the Person that is legally accountable for the CreativeWork.</summary>
		public Person AccountablePerson {get; set;}
		///<summary>The overall rating, based on a collection of reviews or ratings, of the item.</summary>
		public AggregateRating AggregateRating {get; set;}
		///<summary>A secondary title of the CreativeWork.</summary>
		public Text AlternativeHeadline {get; set;}
		///<summary>A media object that encodes this CreativeWork. This property is a synonym for encoding.</summary>
		public MediaObject AssociatedMedia {get; set;}
		///<summary>An intended audience, i.e. a group for whom something was created. Supersedes serviceAudience.</summary>
		public Audience Audience {get; set;}
		///<summary>An embedded audio object.</summary>
		public AudioObject Audio {get; set;}
		///<summary>The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.</summary>
		public OneOfThese<Organization,Person> Author {get; set;}
		///<summary>An award won by or for this item. Supersedes awards.</summary>
		public Text Award {get; set;}
		///<summary>Fictional person connected with a creative work.</summary>
		public Person Character {get; set;}
		///<summary>A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.</summary>
		public OneOfThese<CreativeWork,Text> Citation {get; set;}
		///<summary>Comments, typically from users.</summary>
		public Comment Comment {get; set;}
		///<summary>The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.</summary>
		public Integer CommentCount {get; set;}
		///<summary>The location depicted or described in the content. For example, the location in a photograph or painting.</summary>
		public Place ContentLocation {get; set;}
		///<summary>Official rating of a piece of content—for example,'MPAA PG-13'.</summary>
		public OneOfThese<Rating,Text> ContentRating {get; set;}
		///<summary>The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.</summary>
		public Bam.Net.Schema.Org.DataTypes.Date ContentReferenceTime {get; set;}
		///<summary>A secondary contributor to the CreativeWork or Event.</summary>
		public OneOfThese<Organization,Person> Contributor {get; set;}
		///<summary>The party holding the legal copyright to the CreativeWork.</summary>
		public OneOfThese<Organization,Person> CopyrightHolder {get; set;}
		///<summary>The year during which the claimed copyright for the CreativeWork was first asserted.</summary>
		public Number CopyrightYear {get; set;}
		///<summary>Indicates a correction to a CreativeWork, either via a CorrectionComment, textually or in another document.</summary>
		public OneOfThese<CorrectionComment,Text,Url> Correction {get; set;}
		///<summary>The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.</summary>
		public OneOfThese<Organization,Person> Creator {get; set;}
		///<summary>The date on which the CreativeWork was created or the item was added to a DataFeed.</summary>
		public OneOfThese<Bam.Net.Schema.Org.DataTypes.Date,Bam.Net.Schema.Org.DataTypes.Date> DateCreated {get; set;}
		///<summary>The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.</summary>
		public OneOfThese<Bam.Net.Schema.Org.DataTypes.Date,Bam.Net.Schema.Org.DataTypes.Date> DateModified {get; set;}
		///<summary>Date of first broadcast/publication.</summary>
		public Bam.Net.Schema.Org.DataTypes.Date DatePublished {get; set;}
		///<summary>A link to the page containing the comments of the CreativeWork.</summary>
		public Url DiscussionUrl {get; set;}
		///<summary>Specifies the Person who edited the CreativeWork.</summary>
		public Person Editor {get; set;}
		///<summary>An alignment to an established educational framework.</summary>
		public AlignmentObject EducationalAlignment {get; set;}
		///<summary>The purpose of a work in the context of education; for example, 'assignment', 'group work'.</summary>
		public Text EducationalUse {get; set;}
		///<summary>A media object that encodes this CreativeWork. This property is a synonym for associatedMedia. Supersedes encodings.</summary>
		public MediaObject Encoding {get; set;}
		///<summary>Media type typically expressed using a MIME format (see IANA site and MDN reference) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).In cases where a CreativeWork has several media type representations, encoding can be used to indicate each MediaObject alongside particular encodingFormat information.Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry. Supersedes fileFormat.</summary>
		public OneOfThese<Text,Url> EncodingFormat {get; set;}
		///<summary>A creative work that this work is an example/instance/realization/derivation of. Inverse property: workExample.</summary>
		public CreativeWork ExampleOfWork {get; set;}
		///<summary>Date the content expires and is no longer useful or available. For example a VideoObject or NewsArticle whose availability or relevance is time-limited, or a ClaimReview fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.</summary>
		public Bam.Net.Schema.Org.DataTypes.Date Expires {get; set;}
		///<summary>A person or organization that supports (sponsors) something through some kind of financial contribution.</summary>
		public OneOfThese<Organization,Person> Funder {get; set;}
		///<summary>Genre of the creative work, broadcast channel or group.</summary>
		public OneOfThese<Text,Url> Genre {get; set;}
		///<summary>Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense). Inverse property: isPartOf.</summary>
		public OneOfThese<CreativeWork,Trip> HasPart {get; set;}
		///<summary>Headline of the article.</summary>
		public Text Headline {get; set;}
		///<summary>The language of the content or performance or used in an action. Please use one of the language codes from the IETF BCP 47 standard. See also availableLanguage. Supersedes language.</summary>
		public OneOfThese<Language,Text> InLanguage {get; set;}
		///<summary>The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used. Supersedes interactionCount.</summary>
		public InteractionCounter InteractionStatistic {get; set;}
		///<summary>The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.</summary>
		public Text InteractivityType {get; set;}
		///<summary>A flag to signal that the item, event, or place is accessible for free. Supersedes free.</summary>
		public Boolean IsAccessibleForFree {get; set;}
		///<summary>A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html. Supersedes isBasedOnUrl.</summary>
		public OneOfThese<CreativeWork,Product,Url> IsBasedOn {get; set;}
		///<summary>Indicates whether this content is family friendly.</summary>
		public Boolean IsFamilyFriendly {get; set;}
		///<summary>Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of. Inverse property: hasPart.</summary>
		public OneOfThese<CreativeWork,Trip> IsPartOf {get; set;}
		///<summary>Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.</summary>
		public Text Keywords {get; set;}
		///<summary>The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.</summary>
		public Text LearningResourceType {get; set;}
		///<summary>A license document that applies to this content, typically indicated by URL.</summary>
		public OneOfThese<CreativeWork,Url> License {get; set;}
		///<summary>The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.</summary>
		public Place LocationCreated {get; set;}
		///<summary>Indicates the primary entity described in some page or other CreativeWork. Inverse property: mainEntityOfPage.</summary>
		public Thing MainEntity {get; set;}
		///<summary>A material that something is made from, e.g. leather, wool, cotton, paper.</summary>
		public OneOfThese<Product,Text,Url> Material {get; set;}
		///<summary>Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.</summary>
		public Thing Mentions {get; set;}
		///<summary>An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.</summary>
		public Offer Offers {get; set;}
		///<summary>The position of an item in a series or sequence of items.</summary>
		public OneOfThese<Integer,Text> Position {get; set;}
		///<summary>The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).</summary>
		public OneOfThese<Organization,Person> Producer {get; set;}
		///<summary>The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.</summary>
		public OneOfThese<Organization,Person> Provider {get; set;}
		///<summary>A publication event associated with the item.</summary>
		public PublicationEvent Publication {get; set;}
		///<summary>The publisher of the creative work.</summary>
		public OneOfThese<Organization,Person> Publisher {get; set;}
		///<summary>The publishing division which published the comic.</summary>
		public Organization PublisherImprint {get; set;}
		///<summary>The publishingPrinciples property indicates (typically via URL) a document describing the editorial principles of an Organization (or individual e.g. a Person writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a CreativeWork (e.g. NewsArticle) the principles are those of the party primarily responsible for the creation of the CreativeWork.While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a funder) can be expressed using schema.org terminology.</summary>
		public OneOfThese<CreativeWork,Url> PublishingPrinciples {get; set;}
		///<summary>The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event. Inverse property: recordedIn.</summary>
		public Event RecordedAt {get; set;}
		///<summary>The place and time the release was issued, expressed as a PublicationEvent.</summary>
		public PublicationEvent ReleasedEvent {get; set;}
		///<summary>A review of the item. Supersedes reviews.</summary>
		public Review Review {get; set;}
		///<summary>Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.</summary>
		public OneOfThese<Text,Url> SchemaVersion {get; set;}
		///<summary>Indicates the date on which the current structured data was generated / published. Typically used alongside sdPublisher</summary>
		public Bam.Net.Schema.Org.DataTypes.Date SdDatePublished {get; set;}
		///<summary>A license document that applies to this structured data, typically indicated by URL.</summary>
		public OneOfThese<CreativeWork,Url> SdLicense {get; set;}
		///<summary>Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. ThesdPublisher property helps make such practices more explicit.</summary>
		public OneOfThese<Organization,Person> SdPublisher {get; set;}
		///<summary>The Organization on whose behalf the creator was working.</summary>
		public Organization SourceOrganization {get; set;}
		///<summary>The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of      contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates      areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York. Supersedes spatial.</summary>
		public Place SpatialCoverage {get; set;}
		///<summary>A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.</summary>
		public OneOfThese<Organization,Person> Sponsor {get; set;}
		///<summary>The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in ISO 8601 time interval format. In      the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.      Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated. Supersedes datasetTimeInterval, temporal.</summary>
		public OneOfThese<Bam.Net.Schema.Org.DataTypes.Date,Text,Url> TemporalCoverage {get; set;}
		///<summary>The textual content of this CreativeWork.</summary>
		public Text Text {get; set;}
		///<summary>A thumbnail image relevant to the Thing.</summary>
		public Url ThumbnailUrl {get; set;}
		///<summary>Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.</summary>
		public Duration TimeRequired {get; set;}
		///<summary>The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species” Inverse property: workTranslation.</summary>
		public CreativeWork TranslationOfWork {get; set;}
		///<summary>Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.</summary>
		public OneOfThese<Organization,Person> Translator {get; set;}
		///<summary>The typical expected age range, e.g. '7-9', '11-'.</summary>
		public Text TypicalAgeRange {get; set;}
		///<summary>The version of the CreativeWork embodied by a specified resource.</summary>
		public OneOfThese<Number,Text> Version {get; set;}
		///<summary>An embedded video object.</summary>
		public VideoObject Video {get; set;}
		///<summary>Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook. Inverse property: exampleOfWork.</summary>
		public CreativeWork WorkExample {get; set;}
		///<summary>A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo. Inverse property: translationOfWork.</summary>
		public CreativeWork WorkTranslation {get; set;}
	}
}
