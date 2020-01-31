using System;
using System.Collections.Generic;
using System.Text;

namespace WebserviceChallengeUnitTests
{
    static class ContractTestsUtilities
    {
        public static string GetXMLFormat()
        {
            string xml = @"<?xml version='1.0' standalone='no'?>
            <root>
              <person id='1'>
              <name>Alan</name>
              <url>http://www.google.com</url>
              </person>
              <person id='2'>
              <name>Louis</name>
              <url>http://www.yahoo.com</url>
              </person>
            </root>";

            return xml;
        }

        public static string GetJsonResult()
        {
            return "{\"root\":{\"person\":[{\"@id\":\"1\",\"name\":\"Alan\",\"url\":\"http://www.google.com\"},{\"@id\":\"2\",\"name\":\"Louis\",\"url\":\"http://www.yahoo.com\"}]}}";
        }
    }
}
