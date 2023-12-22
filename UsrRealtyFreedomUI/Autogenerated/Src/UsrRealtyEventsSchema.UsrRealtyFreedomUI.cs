namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("854ec619-8ed9-4922-af22-da8481489cde");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7560b7e5-afe5-410a-ba52-1815d3492787");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,223,107,219,48,16,126,47,244,127,56,76,31,108,8,162,125,109,183,66,147,165,35,80,182,81,59,125,41,125,80,228,139,171,161,31,70,146,211,101,99,255,251,78,150,211,164,78,7,61,12,150,78,223,125,247,125,199,25,174,209,183,92,32,84,232,28,247,118,29,216,204,154,181,108,58,199,131,180,230,244,228,207,233,9,80,116,94,154,6,202,173,15,168,175,14,83,135,133,90,91,243,223,71,135,108,110,130,12,18,253,71,48,108,190,65,19,118,208,199,62,189,237,115,119,146,68,24,116,121,41,158,81,243,111,228,1,62,67,182,244,238,30,185,10,219,91,135,88,91,189,92,100,197,83,170,110,187,149,146,2,132,226,222,67,2,189,195,7,151,48,229,30,223,121,73,44,195,36,14,8,237,134,180,203,26,97,99,101,13,223,77,201,55,228,40,183,171,159,40,2,120,52,53,186,9,36,194,41,174,201,94,79,123,227,26,15,88,236,233,14,152,99,172,72,5,123,101,219,209,96,113,245,22,150,120,193,245,126,104,2,121,74,20,169,96,4,174,81,72,205,21,180,78,138,56,174,84,197,190,98,168,182,45,214,51,171,58,109,30,184,234,240,211,0,189,206,227,72,127,68,252,178,252,146,141,187,203,53,228,137,236,26,46,206,119,81,188,5,141,140,197,64,182,240,51,110,4,42,172,73,71,112,29,18,243,49,206,7,23,183,131,246,211,243,6,43,212,173,226,33,42,55,248,2,119,86,112,37,127,243,149,194,178,199,229,131,159,165,71,71,11,108,104,254,180,189,236,30,189,237,156,32,144,117,196,50,57,110,19,99,191,58,105,231,178,9,100,71,29,60,235,167,179,240,149,181,83,217,164,91,86,176,202,14,10,138,15,216,32,249,41,193,110,173,211,60,228,35,123,212,248,130,157,79,207,142,166,29,35,60,59,251,210,219,159,255,18,216,70,131,187,250,49,252,239,254,58,28,233,71,223,63,133,56,213,206,240,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e12b05a6-8506-fa76-dd15-653aa9d98ad2"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("7560b7e5-afe5-410a-ba52-1815d3492787"),
				CreatedInSchemaUId = new Guid("854ec619-8ed9-4922-af22-da8481489cde"),
				ModifiedInSchemaUId = new Guid("854ec619-8ed9-4922-af22-da8481489cde")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("854ec619-8ed9-4922-af22-da8481489cde"));
		}

		#endregion

	}

	#endregion

}

