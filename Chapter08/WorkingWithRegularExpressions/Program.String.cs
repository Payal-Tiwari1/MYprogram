using System;
using System.Collections.Generic;
using System.Text;


     partial class Program
    {
        const string digitsOnlyText = @"^\d+$";
        const string commaSeparatorText =
        "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";
    }

