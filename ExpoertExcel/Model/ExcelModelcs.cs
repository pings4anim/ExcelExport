namespace ExpoertExcel.Model
{
    public class ExcelModelcs
    {
            /// <summary>
            /// Gets or sets User Id
            /// </summary>
            /// 
            public Guid UserId { get; set; }

            /// <summary>
            /// Gets or sets First Name
            /// </summary>       
            public string? FirstName { get; set; }

            /// <summary>
            /// Gets or sets Middle Name
            /// </summary>       
            public string? MiddleName { get; set; }

            /// <summary>
            /// Gets or sets Last Name
            /// </summary>        
            public string? LastName { get; set; }

            /// <summary>
            /// Gets or sets Preferred Name
            /// </summary>        
            public string? PreferredName { get; set; }

            /// <summary>
            /// Gets or sets Contact Number
            /// </summary>        
            public string? ContactNumber { get; set; }

            /// <summary>
            /// Gets or sets Contact Number2
            /// </summary>        
            public string? ContactNumber2 { get; set; }

            /// <summary>
            /// Gets or sets Secondary Email
            /// </summary>        
            public string? SecondaryEmail { get; set; }

            /// <summary>
            /// Gets or sets EmailId
            /// </summary>
            public string EmailId { get; set; }
    }
}
