using System;
using System.Collections.Generic;

// C# program to generate all possible
// valid IP addresses from given string

// Driver Code 
class HelloWorld {
	
	// Function checks whether IP digits
	// are valid or not.
	static int is_valid(string ip){
		// Splitting by "."
		List<string> ips = new List<string>();
		string ex = "";
		for (int i = 0; i < ip.Length; i++) {
			if (ip[i] == '.') {
				ips.Add(ex);
				ex = "";
			}
			else {
				ex = ex + ip[i];
			}
		}
		ips.Add(ex);

		// Checking for the corner cases
		// cout << ip << endl;
		for (int i = 0; i < ips.Count; i++) {
			// cout << ips[i] <<endl;
			if (ips[i].Length > 3 || Int64.Parse(ips[i]) < 0 || Int64.Parse(ips[i]) > 255)
				return 0;

			if (ips[i].Length > 1 && Int64.Parse(ips[i]) == 0)
				return 0;

			if (ips[i].Length > 1
				&& Int64.Parse(ips[i]) != 0
				&& ips[i][0] == '0')
				return 0;
		}
		return 1;
	}
	
	// Function converts string to IP address
	static void convert(string ip){
		int l = ip.Length;

		// Check for string size
		if (l > 12 || l < 4) {
			Console.WriteLine("Not Valid IP Address");
		}

		string check = ip;
		List<string> ans = new List<string>();

		// Generating different combinations.
		for (int i = 1; i < l - 2; i++) {
			for (int j = i + 1; j < l - 1; j++) {
				for (int k = j + 1; k < l; k++) {
					check = check.Substring(0, k) + "." + check.Substring(k);
					check = check.Substring(0, j) + "." + check.Substring(j);
					check = check.Substring(0, i) + "." + check.Substring(i);

					// cout<< check <<endl;
					// Check for the validity of combination
					if (is_valid(check) != 0) {
						ans.Add(check);
						Console.WriteLine(check);
					}
					check = ip;
				}
			}
		}
	}
	
	static void Main() {
		string A = "25525511135";
		string B = "25505011535";
		
		convert(A);
		convert(B);
	}
}