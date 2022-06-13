<%@ Page Language="C#" ContentType="text/html" %>

<script runat="server">
    static List<String[]> employees = new List<String[]> {
                new string[] { "1", "Nancy", "Davolio", "Sales Representative", "1948-12-08",
                            "1992-05-01", "507 - 20th Ave. E. Apt. 2A", "Seattle" },
                new string[] { "2", "Andrew", "Fuller", "Vice President, Sales", "1952-02-19",
                            "1992-08-14", "908 W. Capital Way", "Tacoma" },
                new string[]{ "3", "Janet", "Leverling", "Sales Representative", "1963-08-30",
                            "1992-04-01", "722 Moss Bay Blvd.", "Kirkland" },
                new string[]{ "4", "Margaret", "Peacock", "Sales Representative", "1937-09-19",
                            "1993-05-03", "4110 Old Redmond Rd.", "Redmond" },
                new string[] { "5", "Steven", "Buchanan", "Sales Manager", "1955-03-04",
                            "1993-10-17", "14 Garrett Hill", "London" },
                new string[] { "6", "Michael", "Suyama", "Sales Representative", "1963-07-02",
                            "1993-10-17", "Coventry House Miner Rd.", "London" },
                new string[]{ "7", "Robert", "King", "Sales Representative", "2015-03-11",
                            "1994-01-02", "Edgeham Hollow Winchester Way", "London" },
                new string[] { "8", "Laura", "Callahan", "Inside Sales Coordinator",
                            "2015-03-19", "1994-03-05", "4726 - 11th Ave. N.E.", "Seattle" },
                new string[] { "9", "anne", "Dodsworth", "Sales Representative", "2015-03-04",
                            "1994-11-15", "7 Houndstooth Rd.", "London" }
        };

    private void Page_Load(Object sender, EventArgs e)
    {
        IEnumerable<string> empNames = from emp in employees
                                       where emp[1].ToUpper().Contains(Request["term"].ToUpper())
                                       select emp[1];
        string jsonStr = "[";
        int count = empNames.Count();
        int index = 0;
        foreach (var empName in empNames)
        {
            jsonStr += "\"" +empName+ "\"";
            if (index++ < count - 1)
                jsonStr += ",";
        }
        jsonStr += "]";
        System.Threading.Thread.Sleep(500);
        Response.Write(jsonStr);
    }
</script>

