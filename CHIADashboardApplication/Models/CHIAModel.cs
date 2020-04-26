using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHIADashboardApplication.Models
{
    public class ChiaDetails
    {
        public List<ChiaIssueDetails> issueInfo { get; set; }

        [Display(Name = "From Date")]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date")]
        public DateTime? ToDate { get; set; }

        public List<SelectListItem> DeptList { get; set; }

        public string SelDept { get; set; }
    }

    public class ChiaIssueDetails
    {
        public string key { get; set; }
        public string summary { get; set; }
        public string createdDate { get; set; }
        public string status { get; set; }
        public string CHIA_Id { get; set; }
        public string CHIA_CR { get; set; }
        public string CR_url { get; set; }
        public string compliance_Analyst { get; set; }
        public int age { get; set; }
        public string comment { get; set; }
    }

    public class Rootobject
    {
        public string expand { get; set; }
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public Issue[] issues { get; set; }
    }

    public class Issue
    {
        public string expand { get; set; }
        public string id { get; set; }
        public string self { get; set; }
        public string key { get; set; }
        public Fields fields { get; set; }
    }

    public class Fields
    {
        public object customfield_20431 { get; set; }
        public object customfield_20432 { get; set; }
        public object customfield_20430 { get; set; }
        public object customfield_22608 { get; set; }
        public object customfield_20428 { get; set; }
        public object customfield_22607 { get; set; }
        public object customfield_12807 { get; set; }
        public object customfield_20429 { get; set; }
        public object customfield_22606 { get; set; }
        public Customfield_20426 customfield_20426 { get; set; }
        public string customfield_22605 { get; set; }
        public object customfield_20427 { get; set; }
        public object customfield_22604 { get; set; }
        public string customfield_20424 { get; set; }
        public object customfield_22603 { get; set; }
        public object customfield_20425 { get; set; }
        public object customfield_22602 { get; set; }
        public object customfield_20422 { get; set; }
        public object customfield_22601 { get; set; }
        public object customfield_22600 { get; set; }
        public string customfield_20420 { get; set; }
        public object customfield_19431 { get; set; }
        public Customfield_20421 customfield_20421 { get; set; }
        public object customfield_24801 { get; set; }
        public object lastViewed { get; set; }
        public object customfield_19434 { get; set; }
        public object customfield_24804 { get; set; }
        public object customfield_24805 { get; set; }
        public object customfield_24806 { get; set; }
        public object customfield_19430 { get; set; }
        public object customfield_24809 { get; set; }
        public object customfield_19435 { get; set; }
        public object customfield_19436 { get; set; }
        public string customfield_31100 { get; set; }
        public object customfield_31102 { get; set; }
        public string customfield_31101 { get; set; }
        public object aggregatetimeoriginalestimate { get; set; }
        public string customfield_20419 { get; set; }
        public string customfield_20417 { get; set; }
        public Issuelink[] issuelinks { get; set; }
        public object customfield_20415 { get; set; }
        public object customfield_20416 { get; set; }
        public object customfield_20413 { get; set; }
        public object customfield_20414 { get; set; }
        public object customfield_20411 { get; set; }
        public object customfield_24810 { get; set; }
        public object customfield_19420 { get; set; }
        public object customfield_19421 { get; set; }
        public object customfield_20410 { get; set; }
        public object customfield_19428 { get; set; }
        public object customfield_19424 { get; set; }
        public object customfield_19425 { get; set; }
        public object customfield_10604 { get; set; }
        public object customfield_10605 { get; set; }
        public object customfield_20408 { get; set; }
        public string customfield_20409 { get; set; }
        public string customfield_20406 { get; set; }
        public object customfield_20407 { get; set; }
        public object customfield_20404 { get; set; }
        public object customfield_20405 { get; set; }
        public object customfield_20402 { get; set; }
        public object customfield_20403 { get; set; }
        public string customfield_20401 { get; set; }
        public string customfield_19411 { get; set; }
        public object customfield_19412 { get; set; }
        public object[] subtasks { get; set; }
        public object customfield_19418 { get; set; }
        public string customfield_19413 { get; set; }
        public object customfield_19414 { get; set; }
        public object customfield_33301 { get; set; }
        public object customfield_33300 { get; set; }
        public object customfield_23500 { get; set; }
        public object customfield_23501 { get; set; }
        public object customfield_23502 { get; set; }
        public object customfield_23503 { get; set; }
        public object customfield_23504 { get; set; }
        public object customfield_23506 { get; set; }
        public object customfield_19407 { get; set; }
        public object customfield_19408 { get; set; }
        public object customfield_19409 { get; set; }
        public Customfield_19403 customfield_19403 { get; set; }
        public object customfield_19404 { get; set; }
        public object customfield_19405 { get; set; }
        public object customfield_17211 { get; set; }
        public object customfield_11900 { get; set; }
        public object customfield_11901 { get; set; }
        public object customfield_21707 { get; set; }
        public object customfield_11903 { get; set; }
        public string customfield_21703 { get; set; }
        public string customfield_21702 { get; set; }
        public string customfield_21701 { get; set; }
        public object customfield_25700 { get; set; }
        public object customfield_25701 { get; set; }
        public object customfield_25702 { get; set; }
        public object customfield_25703 { get; set; }
        public object customfield_25704 { get; set; }
        public object customfield_25705 { get; set; }
        public object customfield_25706 { get; set; }
        public object customfield_25707 { get; set; }
        public object customfield_25708 { get; set; }
        public object customfield_25709 { get; set; }
        public object customfield_17205 { get; set; }
        public object customfield_17204 { get; set; }
        public object customfield_17203 { get; set; }
        public object customfield_17202 { get; set; }
        public object customfield_17209 { get; set; }
        public object customfield_17208 { get; set; }
        public object customfield_17207 { get; set; }
        public object customfield_17206 { get; set; }
        public object customfield_32002 { get; set; }
        public object customfield_32001 { get; set; }
        public object customfield_32004 { get; set; }
        public object customfield_32003 { get; set; }
        public object customfield_32000 { get; set; }
        public string customfield_25712 { get; set; }
        public object customfield_25713 { get; set; }
        public object customfield_25714 { get; set; }
        public object customfield_25715 { get; set; }
        public string customfield_25716 { get; set; }
        public object customfield_25717 { get; set; }
        public object customfield_25718 { get; set; }
        public object customfield_25719 { get; set; }
        public object customfield_32009 { get; set; }
        public object customfield_32006 { get; set; }
        public string customfield_32005 { get; set; }
        public object customfield_32008 { get; set; }
        public object customfield_32007 { get; set; }
        public object customfield_32013 { get; set; }
        public object customfield_32012 { get; set; }
        public object customfield_32015 { get; set; }
        public object customfield_32014 { get; set; }
        public object customfield_32011 { get; set; }
        public object customfield_32010 { get; set; }
        public object customfield_20835 { get; set; }
        public object customfield_20836 { get; set; }
        public object customfield_20833 { get; set; }
        public object customfield_20832 { get; set; }
        public object customfield_25721 { get; set; }
        public object customfield_25722 { get; set; }
        public object customfield_27901 { get; set; }
        public object customfield_20830 { get; set; }
        public object customfield_25723 { get; set; }
        public object customfield_27900 { get; set; }
        public object customfield_22213 { get; set; }
        public object customfield_22212 { get; set; }
        public object customfield_22211 { get; set; }
        public object customfield_22210 { get; set; }
        public object customfield_15921 { get; set; }
        public object customfield_15914 { get; set; }
        public object customfield_15913 { get; set; }
        public object customfield_15918 { get; set; }
        public string customfield_29652 { get; set; }
        public object customfield_15919 { get; set; }
        public string customfield_29653 { get; set; }
        public object customfield_15916 { get; set; }
        public object customfield_15917 { get; set; }
        public object customfield_28320 { get; set; }
        public object customfield_28325 { get; set; }
        public object customfield_29656 { get; set; }
        public object customfield_28326 { get; set; }
        public object customfield_22209 { get; set; }
        public object customfield_29654 { get; set; }
        public object customfield_28323 { get; set; }
        public object customfield_22208 { get; set; }
        public object customfield_28324 { get; set; }
        public object customfield_29655 { get; set; }
        public object customfield_22207 { get; set; }
        public object customfield_22205 { get; set; }
        public object customfield_29658 { get; set; }
        public object customfield_22204 { get; set; }
        public object customfield_28328 { get; set; }
        public object customfield_22203 { get; set; }
        public object customfield_22202 { get; set; }
        public object customfield_22201 { get; set; }
        public object customfield_22200 { get; set; }
        public object customfield_15907 { get; set; }
        public string customfield_28332 { get; set; }
        public object customfield_27000 { get; set; }
        public object timeestimate { get; set; }
        public object customfield_15908 { get; set; }
        public object customfield_28330 { get; set; }
        public object customfield_27002 { get; set; }
        public object customfield_15906 { get; set; }
        public string customfield_28331 { get; set; }
        public object customfield_27001 { get; set; }
        public object customfield_27004 { get; set; }
        public object customfield_28337 { get; set; }
        public object customfield_27003 { get; set; }
        public object customfield_20019 { get; set; }
        public object customfield_15909 { get; set; }
        public object customfield_27006 { get; set; }
        public object customfield_27005 { get; set; }
        public object customfield_20015 { get; set; }
        public object customfield_28338 { get; set; }
        public object customfield_20016 { get; set; }
        public object customfield_28339 { get; set; }
        public object customfield_20014 { get; set; }
        public object customfield_31507 { get; set; }
        public object customfield_31504 { get; set; }
        public object customfield_31503 { get; set; }
        public string customfield_31506 { get; set; }
        public object customfield_31505 { get; set; }
        public object customfield_15900 { get; set; }
        public object customfield_31502 { get; set; }
        public object customfield_31501 { get; set; }
        public object customfield_28340 { get; set; }
        public string customfield_10205 { get; set; }
        public object customfield_10206 { get; set; }
        public object customfield_10207 { get; set; }
        public object customfield_27011 { get; set; }
        public object customfield_10208 { get; set; }
        public object customfield_28341 { get; set; }
        public object customfield_28342 { get; set; }
        public object customfield_27015 { get; set; }
        public object customfield_20008 { get; set; }
        public object customfield_20006 { get; set; }
        public object customfield_20007 { get; set; }
        public object customfield_20004 { get; set; }
        public object customfield_20005 { get; set; }
        public object customfield_20002 { get; set; }
        public object customfield_20003 { get; set; }
        public string customfield_10200 { get; set; }
        public object customfield_10201 { get; set; }
        public object customfield_10202 { get; set; }
        public object customfield_29202 { get; set; }
        public object customfield_29200 { get; set; }
        public string customfield_29206 { get; set; }
        public string customfield_29209 { get; set; }
        public object customfield_29207 { get; set; }
        public object customfield_22655 { get; set; }
        public object customfield_29208 { get; set; }
        public object customfield_21323 { get; set; }
        public object customfield_22654 { get; set; }
        public object customfield_21322 { get; set; }
        public object customfield_22653 { get; set; }
        public object customfield_21321 { get; set; }
        public object customfield_22652 { get; set; }
        public object customfield_23900 { get; set; }
        public object customfield_21320 { get; set; }
        public object customfield_19005 { get; set; }
        public object customfield_22651 { get; set; }
        public object customfield_22650 { get; set; }
        public object aggregatetimespent { get; set; }
        public object customfield_19007 { get; set; }
        public object customfield_12853 { get; set; }
        public object customfield_12844 { get; set; }
        public object customfield_12843 { get; set; }
        public object customfield_12846 { get; set; }
        public object customfield_12845 { get; set; }
        public object customfield_30200 { get; set; }
        public Customfield_29212 customfield_29212 { get; set; }
        public Customfield_29213 customfield_29213 { get; set; }
        public object customfield_29210 { get; set; }
        public Customfield_29211 customfield_29211 { get; set; }
        public object customfield_21319 { get; set; }
        public object customfield_21318 { get; set; }
        public object customfield_22649 { get; set; }
        public object customfield_21317 { get; set; }
        public object customfield_22648 { get; set; }
        public object customfield_22647 { get; set; }
        public object customfield_22646 { get; set; }
        public object customfield_22645 { get; set; }
        public Customfield_21313[] customfield_21313 { get; set; }
        public object customfield_22644 { get; set; }
        public object customfield_21312 { get; set; }
        public object customfield_21311 { get; set; }
        public object customfield_21310 { get; set; }
        public object customfield_20462 { get; set; }
        public Customfield_22640 customfield_22640 { get; set; }
        public object customfield_20460 { get; set; }
        public object customfield_20461 { get; set; }
        public object customfield_12842 { get; set; }
        public string customfield_12841 { get; set; }
        public object customfield_12833 { get; set; }
        public string customfield_12835 { get; set; }
        public object customfield_12834 { get; set; }
        public object customfield_21309 { get; set; }
        public Customfield_21308 customfield_21308 { get; set; }
        public object customfield_22639 { get; set; }
        public object customfield_20459 { get; set; }
        public object customfield_21306 { get; set; }
        public object customfield_20457 { get; set; }
        public object customfield_22636 { get; set; }
        public object customfield_21304 { get; set; }
        public object customfield_20458 { get; set; }
        public object customfield_22635 { get; set; }
        public string customfield_21303 { get; set; }
        public object customfield_20455 { get; set; }
        public object customfield_22634 { get; set; }
        public object customfield_20456 { get; set; }
        public string customfield_21302 { get; set; }
        public object customfield_22633 { get; set; }
        public object customfield_21301 { get; set; }
        public object customfield_22632 { get; set; }
        public object customfield_20454 { get; set; }
        public object customfield_22631 { get; set; }
        public object customfield_20451 { get; set; }
        public object customfield_22630 { get; set; }
        public object customfield_20452 { get; set; }
        public object customfield_30217 { get; set; }
        public object customfield_30218 { get; set; }
        public object customfield_30219 { get; set; }
        public object customfield_30214 { get; set; }
        public object customfield_30215 { get; set; }
        public object customfield_12821 { get; set; }
        public object customfield_30220 { get; set; }
        public object customfield_30221 { get; set; }
        public object customfield_32400 { get; set; }
        public object customfield_30222 { get; set; }
        public object customfield_20448 { get; set; }
        public object customfield_20446 { get; set; }
        public object customfield_20445 { get; set; }
        public object customfield_20442 { get; set; }
        public object customfield_19455 { get; set; }
        public object customfield_32406 { get; set; }
        public object customfield_32405 { get; set; }
        public object customfield_30229 { get; set; }
        public object customfield_32408 { get; set; }
        public object customfield_32407 { get; set; }
        public object customfield_30223 { get; set; }
        public object customfield_32402 { get; set; }
        public object customfield_32401 { get; set; }
        public object customfield_12820 { get; set; }
        public object customfield_32404 { get; set; }
        public object customfield_32403 { get; set; }
        public object customfield_12819 { get; set; }
        public object customfield_20437 { get; set; }
        public object customfield_20438 { get; set; }
        public object customfield_20435 { get; set; }
        public object customfield_20436 { get; set; }
        public string customfield_20433 { get; set; }
        public object customfield_20434 { get; set; }
        public object customfield_23028 { get; set; }
        public object customfield_23027 { get; set; }
        public object customfield_27869 { get; set; }
        public object customfield_23026 { get; set; }
        public object customfield_23025 { get; set; }
        public object customfield_23024 { get; set; }
        public object customfield_23023 { get; set; }
        public object customfield_23022 { get; set; }
        public object customfield_23021 { get; set; }
        public object customfield_18911 { get; set; }
        public object customfield_23020 { get; set; }
        public object customfield_15401 { get; set; }
        public object customfield_18912 { get; set; }
        public object customfield_18913 { get; set; }
        public object customfield_18914 { get; set; }
        public object customfield_15404 { get; set; }
        public object customfield_15405 { get; set; }
        public object customfield_15402 { get; set; }
        public object customfield_15403 { get; set; }
        public object customfield_27871 { get; set; }
        public object customfield_27870 { get; set; }
        public object customfield_27873 { get; set; }
        public object customfield_25211 { get; set; }
        public object customfield_27872 { get; set; }
        public object customfield_25212 { get; set; }
        public object customfield_27875 { get; set; }
        public object customfield_27874 { get; set; }
        public object customfield_27877 { get; set; }
        public object customfield_23019 { get; set; }
        public object customfield_27879 { get; set; }
        public object customfield_23018 { get; set; }
        public object[] customfield_27878 { get; set; }
        public object customfield_23017 { get; set; }
        public object customfield_23016 { get; set; }
        public object customfield_23015 { get; set; }
        public object customfield_23014 { get; set; }
        public object customfield_23013 { get; set; }
        public object customfield_23010 { get; set; }
        public object customfield_18900 { get; set; }
        public object customfield_18901 { get; set; }
        public string[] labels { get; set; }
        public object customfield_27880 { get; set; }
        public object customfield_27882 { get; set; }
        public object customfield_27881 { get; set; }
        public object customfield_27400 { get; set; }
        public object customfield_27884 { get; set; }
        public object customfield_27883 { get; set; }
        public object customfield_27402 { get; set; }
        public object customfield_27886 { get; set; }
        public object customfield_27401 { get; set; }
        public string customfield_27885 { get; set; }
        public object customfield_27404 { get; set; }
        public object customfield_23009 { get; set; }
        public object customfield_23008 { get; set; }
        public object customfield_27406 { get; set; }
        public object customfield_23007 { get; set; }
        public object customfield_27405 { get; set; }
        public object customfield_23006 { get; set; }
        public object customfield_27408 { get; set; }
        public object customfield_31908 { get; set; }
        public string customfield_22158 { get; set; }
        public object customfield_23005 { get; set; }
        public object customfield_27407 { get; set; }
        public object customfield_31907 { get; set; }
        public object customfield_22157 { get; set; }
        public object customfield_23004 { get; set; }
        public object customfield_22156 { get; set; }
        public object customfield_23003 { get; set; }
        public object customfield_27409 { get; set; }
        public object customfield_31909 { get; set; }
        public object customfield_22155 { get; set; }
        public object customfield_23002 { get; set; }
        public object customfield_31904 { get; set; }
        public string customfield_22154 { get; set; }
        public object customfield_23001 { get; set; }
        public object customfield_31903 { get; set; }
        public object customfield_22153 { get; set; }
        public object customfield_31906 { get; set; }
        public object customfield_22152 { get; set; }
        public object customfield_31905 { get; set; }
        public object customfield_31900 { get; set; }
        public object customfield_22150 { get; set; }
        public string customfield_13200 { get; set; }
        public object customfield_31901 { get; set; }
        public Customfield_13203 customfield_13203 { get; set; }
        public object customfield_13202 { get; set; }
        public string customfield_13204 { get; set; }
        public object customfield_27411 { get; set; }
        public object customfield_27410 { get; set; }
        public object customfield_27412 { get; set; }
        public object customfield_27417 { get; set; }
        public object customfield_22148 { get; set; }
        public object customfield_27419 { get; set; }
        public object customfield_22147 { get; set; }
        public object customfield_27418 { get; set; }
        public object customfield_31918 { get; set; }
        public object customfield_22146 { get; set; }
        public string customfield_22144 { get; set; }
        public object customfield_31915 { get; set; }
        public object customfield_22143 { get; set; }
        public object customfield_31914 { get; set; }
        public object customfield_22142 { get; set; }
        public object customfield_31917 { get; set; }
        public string customfield_31916 { get; set; }
        public object customfield_31911 { get; set; }
        public Reporter reporter { get; set; }
        public object customfield_11011 { get; set; }
        public string customfield_31913 { get; set; }
        public object customfield_11012 { get; set; }
        public object customfield_31912 { get; set; }
        public object customfield_11006 { get; set; }
        public object customfield_14517 { get; set; }
        public object customfield_14518 { get; set; }
        public object customfield_14515 { get; set; }
        public object customfield_27420 { get; set; }
        public object customfield_27422 { get; set; }
        public object customfield_29601 { get; set; }
        public object customfield_27421 { get; set; }
        public object customfield_29602 { get; set; }
        public object customfield_27423 { get; set; }
        public object customfield_27426 { get; set; }
        public object customfield_29605 { get; set; }
        public object customfield_27425 { get; set; }
        public object customfield_22139 { get; set; }
        public object customfield_27428 { get; set; }
        public string customfield_29603 { get; set; }
        public object customfield_22138 { get; set; }
        public object customfield_29604 { get; set; }
        public object customfield_22137 { get; set; }
        public object customfield_29609 { get; set; }
        public object customfield_22136 { get; set; }
        public object customfield_27429 { get; set; }
        public object customfield_22135 { get; set; }
        public string customfield_29607 { get; set; }
        public object customfield_22134 { get; set; }
        public object customfield_29608 { get; set; }
        public object customfield_22133 { get; set; }
        public object customfield_22132 { get; set; }
        public object customfield_22131 { get; set; }
        public object customfield_22130 { get; set; }
        public object customfield_15841 { get; set; }
        public object customfield_14513 { get; set; }
        public object customfield_14514 { get; set; }
        public object customfield_15842 { get; set; }
        public object customfield_14512 { get; set; }
        public object customfield_15843 { get; set; }
        public Customfield_15837 customfield_15837 { get; set; }
        public object customfield_15838 { get; set; }
        public object customfield_15835 { get; set; }
        public object customfield_15836 { get; set; }
        public object customfield_27431 { get; set; }
        public object customfield_26100 { get; set; }
        public string customfield_26102 { get; set; }
        public object customfield_27433 { get; set; }
        public object customfield_29612 { get; set; }
        public object customfield_27432 { get; set; }
        public object customfield_29613 { get; set; }
        public object customfield_27435 { get; set; }
        public object customfield_29610 { get; set; }
        public object customfield_27434 { get; set; }
        public object customfield_26103 { get; set; }
        public string customfield_29611 { get; set; }
        public object customfield_27437 { get; set; }
        public object customfield_22129 { get; set; }
        public string customfield_29617 { get; set; }
        public object customfield_22128 { get; set; }
        public object customfield_27439 { get; set; }
        public object customfield_22127 { get; set; }
        public object customfield_27438 { get; set; }
        public object customfield_29615 { get; set; }
        public object customfield_22125 { get; set; }
        public object customfield_22124 { get; set; }
        public object customfield_29618 { get; set; }
        public object customfield_22123 { get; set; }
        public object customfield_29619 { get; set; }
        public object customfield_22122 { get; set; }
        public object customfield_22121 { get; set; }
        public string customfield_30606 { get; set; }
        public object customfield_30607 { get; set; }
        public object customfield_30601 { get; set; }
        public object customfield_30602 { get; set; }
        public object customfield_30604 { get; set; }
        public string customfield_27440 { get; set; }
        public object customfield_29620 { get; set; }
        public object customfield_15828 { get; set; }
        public object customfield_27442 { get; set; }
        public object customfield_27441 { get; set; }
        public object customfield_29623 { get; set; }
        public object customfield_27443 { get; set; }
        public object customfield_29621 { get; set; }
        public object customfield_27445 { get; set; }
        public string customfield_29622 { get; set; }
        public object customfield_27448 { get; set; }
        public string customfield_29627 { get; set; }
        public object customfield_27447 { get; set; }
        public object customfield_29628 { get; set; }
        public DateTime updated { get; set; }
        public string customfield_22117 { get; set; }
        public object customfield_22116 { get; set; }
        public object customfield_27449 { get; set; }
        public string customfield_22115 { get; set; }
        public object customfield_22114 { get; set; }
        public object customfield_22113 { get; set; }
        public object customfield_22112 { get; set; }
        public object customfield_12310 { get; set; }
        public Customfield_12312 customfield_12312 { get; set; }
        public object customfield_15820 { get; set; }
        public Customfield_12313 customfield_12313 { get; set; }
        public object customfield_15815 { get; set; }
        public object customfield_15816 { get; set; }
        public object customfield_15814 { get; set; }
        public object customfield_15819 { get; set; }
        public object customfield_27451 { get; set; }
        public string customfield_29630 { get; set; }
        public object customfield_28300 { get; set; }
        public object customfield_29631 { get; set; }
        public object customfield_15817 { get; set; }
        public object customfield_15818 { get; set; }
        public object customfield_27452 { get; set; }
        public string customfield_29634 { get; set; }
        public object customfield_28303 { get; set; }
        public object customfield_29635 { get; set; }
        public string customfield_29632 { get; set; }
        public object customfield_29633 { get; set; }
        public object customfield_28302 { get; set; }
        public object customfield_22108 { get; set; }
        public object customfield_28307 { get; set; }
        public object customfield_29638 { get; set; }
        public object customfield_22107 { get; set; }
        public object customfield_28308 { get; set; }
        public object customfield_29639 { get; set; }
        public object customfield_22106 { get; set; }
        public object customfield_29636 { get; set; }
        public string customfield_28305 { get; set; }
        public object customfield_22105 { get; set; }
        public object customfield_28306 { get; set; }
        public object customfield_29637 { get; set; }
        public object customfield_22104 { get; set; }
        public object customfield_22102 { get; set; }
        public object customfield_28309 { get; set; }
        public object customfield_22100 { get; set; }
        public string customfield_32807 { get; set; }
        public object customfield_32802 { get; set; }
        public DateTime? customfield_32801 { get; set; }
        public object customfield_32803 { get; set; }
        public object customfield_15811 { get; set; }
        public object customfield_15812 { get; set; }
        public object customfield_15810 { get; set; }
        public object customfield_28310 { get; set; }
        public object customfield_15809 { get; set; }
        public object customfield_28311 { get; set; }
        public object customfield_28315 { get; set; }
        public object customfield_29643 { get; set; }
        public object customfield_28312 { get; set; }
        public object customfield_29644 { get; set; }
        public object customfield_28318 { get; set; }
        public object customfield_28319 { get; set; }
        public object customfield_28316 { get; set; }
        public object customfield_28317 { get; set; }
        public object customfield_25605 { get; set; }
        public object customfield_15000 { get; set; }
        public object customfield_15001 { get; set; }
        public object customfield_25608 { get; set; }
        public object customfield_15004 { get; set; }
        public object customfield_15005 { get; set; }
        public object customfield_18511 { get; set; }
        public object customfield_18512 { get; set; }
        public Customfield_15006 customfield_15006 { get; set; }
        public object customfield_15007 { get; set; }
        public object customfield_20828 { get; set; }
        public object customfield_18508 { get; set; }
        public object customfield_18509 { get; set; }
        public object customfield_20829 { get; set; }
        public object customfield_20826 { get; set; }
        public Customfield_20827 customfield_20827 { get; set; }
        public object customfield_20825 { get; set; }
        public Customfield_20822 customfield_20822 { get; set; }
        public object customfield_20823 { get; set; }
        public object customfield_25610 { get; set; }
        public object customfield_20821 { get; set; }
        public object customfield_25611 { get; set; }
        public object customfield_25612 { get; set; }
        public object customfield_16321 { get; set; }
        public object customfield_16320 { get; set; }
        public object customfield_18504 { get; set; }
        public object customfield_16324 { get; set; }
        public object customfield_18506 { get; set; }
        public object customfield_16323 { get; set; }
        public object customfield_16322 { get; set; }
        public object customfield_18501 { get; set; }
        public object customfield_18502 { get; set; }
        public object customfield_20819 { get; set; }
        public object customfield_16319 { get; set; }
        public object customfield_20817 { get; set; }
        public object customfield_20818 { get; set; }
        public object customfield_20815 { get; set; }
        public string customfield_20813 { get; set; }
        public string customfield_20814 { get; set; }
        public string customfield_20811 { get; set; }
        public string customfield_20812 { get; set; }
        public string customfield_20810 { get; set; }
        public object customfield_27801 { get; set; }
        public object customfield_27804 { get; set; }
        public object customfield_27806 { get; set; }
        public object customfield_27805 { get; set; }
        public object customfield_16310 { get; set; }
        public object customfield_27808 { get; set; }
        public object customfield_27807 { get; set; }
        public object customfield_27809 { get; set; }
        public object customfield_16312 { get; set; }
        public object customfield_16318 { get; set; }
        public object customfield_16317 { get; set; }
        public object customfield_16316 { get; set; }
        public string customfield_20808 { get; set; }
        public string customfield_20809 { get; set; }
        public string customfield_20806 { get; set; }
        public string customfield_20807 { get; set; }
        public Customfield_20804 customfield_20804 { get; set; }
        public string customfield_20805 { get; set; }
        public object customfield_20802 { get; set; }
        public object customfield_20800 { get; set; }
        public object customfield_27811 { get; set; }
        public object customfield_24302 { get; set; }
        public object customfield_27810 { get; set; }
        public object customfield_24303 { get; set; }
        public Customfield_24304 customfield_24304 { get; set; }
        public object customfield_24305 { get; set; }
        public object customfield_27815 { get; set; }
        public object customfield_24306 { get; set; }
        public object customfield_27814 { get; set; }
        public object customfield_24308 { get; set; }
        public object customfield_24309 { get; set; }
        public object customfield_27819 { get; set; }
        public object customfield_16303 { get; set; }
        public object customfield_16302 { get; set; }
        public object customfield_16301 { get; set; }
        public object customfield_16307 { get; set; }
        public object customfield_16306 { get; set; }
        public object customfield_27828 { get; set; }
        public object customfield_15440 { get; set; }
        public object customfield_15441 { get; set; }
        public object customfield_15442 { get; set; }
        public object customfield_15439 { get; set; }
        public object customfield_26500 { get; set; }
        public object customfield_27833 { get; set; }
        public object customfield_26502 { get; set; }
        public object customfield_27832 { get; set; }
        public object customfield_26501 { get; set; }
        public object customfield_27835 { get; set; }
        public object customfield_27834 { get; set; }
        public object customfield_27837 { get; set; }
        public object customfield_27836 { get; set; }
        public object customfield_27839 { get; set; }
        public object customfield_15430 { get; set; }
        public DateTime created { get; set; }
        public string customfield_15433 { get; set; }
        public object customfield_15431 { get; set; }
        public object customfield_14100 { get; set; }
        public object customfield_15437 { get; set; }
        public object customfield_15435 { get; set; }
        public object customfield_15436 { get; set; }
        public object customfield_15429 { get; set; }
        public object customfield_27840 { get; set; }
        public object customfield_27841 { get; set; }
        public object customfield_27844 { get; set; }
        public object customfield_27843 { get; set; }
        public object customfield_27846 { get; set; }
        public object customfield_27845 { get; set; }
        public object customfield_27848 { get; set; }
        public object customfield_27847 { get; set; }
        public object customfield_27849 { get; set; }
        public object customfield_15422 { get; set; }
        public object customfield_15423 { get; set; }
        public object customfield_15426 { get; set; }
        public object customfield_15427 { get; set; }
        public object customfield_15425 { get; set; }
        public object customfield_27851 { get; set; }
        public object customfield_27850 { get; set; }
        public object customfield_27853 { get; set; }
        public object customfield_27855 { get; set; }
        public object customfield_27854 { get; set; }
        public object customfield_27857 { get; set; }
        public object customfield_27856 { get; set; }
        public object customfield_27859 { get; set; }
        public object customfield_27858 { get; set; }
        public object customfield_23036 { get; set; }
        public object customfield_23035 { get; set; }
        public object customfield_23034 { get; set; }
        public object customfield_23033 { get; set; }
        public object customfield_23032 { get; set; }
        public object customfield_23031 { get; set; }
        public object customfield_23030 { get; set; }
        public string customfield_15415 { get; set; }
        public object customfield_15407 { get; set; }
        public object customfield_18915 { get; set; }
        public object customfield_18916 { get; set; }
        public object customfield_27860 { get; set; }
        public object[] customfield_27862 { get; set; }
        public object[] customfield_27861 { get; set; }
        public object[] customfield_27864 { get; set; }
        public object customfield_27866 { get; set; }
        public object customfield_25205 { get; set; }
        public object customfield_27868 { get; set; }
        public object customfield_23029 { get; set; }
        public object customfield_27867 { get; set; }
        public object customfield_25206 { get; set; }
        public object customfield_20310 { get; set; }
        public object customfield_18474 { get; set; }
        public object customfield_20311 { get; set; }
        public object customfield_18476 { get; set; }
        public object customfield_18477 { get; set; }
        public object customfield_18470 { get; set; }
        public object customfield_18472 { get; set; }
        public object customfield_19320 { get; set; }
        public object customfield_31449 { get; set; }
        public object customfield_31448 { get; set; }
        public object customfield_18478 { get; set; }
        public string customfield_30113 { get; set; }
        public object customfield_31445 { get; set; }
        public object customfield_18479 { get; set; }
        public object customfield_30114 { get; set; }
        public string customfield_31447 { get; set; }
        public object customfield_31446 { get; set; }
        public object customfield_10500 { get; set; }
        public object customfield_20309 { get; set; }
        public object customfield_31450 { get; set; }
        public object customfield_20308 { get; set; }
        public Customfield_20305 customfield_20305 { get; set; }
        public object customfield_20306 { get; set; }
        public object customfield_21636 { get; set; }
        public string customfield_20303 { get; set; }
        public string customfield_20304 { get; set; }
        public object customfield_20301 { get; set; }
        public object customfield_20302 { get; set; }
        public object customfield_18463 { get; set; }
        public object customfield_19310 { get; set; }
        public object customfield_21631 { get; set; }
        public object customfield_19311 { get; set; }
        public object customfield_20300 { get; set; }
        public object customfield_18464 { get; set; }
        public object customfield_21630 { get; set; }
        public object customfield_18465 { get; set; }
        public object customfield_19312 { get; set; }
        public object customfield_18466 { get; set; }
        public string customfield_18460 { get; set; }
        public object customfield_18461 { get; set; }
        public object customfield_18462 { get; set; }
        public object customfield_19314 { get; set; }
        public object customfield_19315 { get; set; }
        public object customfield_19316 { get; set; }
        public object customfield_21628 { get; set; }
        public Assignee assignee { get; set; }
        public object customfield_19300 { get; set; }
        public object customfield_19302 { get; set; }
        public Customfield_19303 customfield_19303 { get; set; }
        public object customfield_19304 { get; set; }
        public object customfield_19305 { get; set; }
        public object customfield_21618 { get; set; }
        public object customfield_21617 { get; set; }
        public object customfield_21616 { get; set; }
        public object customfield_21614 { get; set; }
        public object customfield_21613 { get; set; }
        public object customfield_21612 { get; set; }
        public object customfield_21611 { get; set; }
        public object customfield_24700 { get; set; }
        public object customfield_24701 { get; set; }
        public object customfield_18442 { get; set; }
        public object customfield_18443 { get; set; }
        public object customfield_24703 { get; set; }
        public object customfield_18444 { get; set; }
        public object customfield_24704 { get; set; }
        public object customfield_24705 { get; set; }
        public object customfield_24706 { get; set; }
        public object customfield_24707 { get; set; }
        public object customfield_24708 { get; set; }
        public object customfield_24709 { get; set; }
        public object customfield_18445 { get; set; }
        public object customfield_18446 { get; set; }
        public object customfield_18448 { get; set; }
        public object customfield_31000 { get; set; }
        public object customfield_31003 { get; set; }
        public object customfield_11800 { get; set; }
        public object customfield_31002 { get; set; }
        public object customfield_21609 { get; set; }
        public object customfield_21608 { get; set; }
        public object customfield_21605 { get; set; }
        public object customfield_21603 { get; set; }
        public object customfield_21601 { get; set; }
        public object customfield_24710 { get; set; }
        public float?  customfield_24711 { get; set; }
        public float? customfield_24712 { get; set; }
        public object customfield_18431 { get; set; }
        public float? customfield_24713 { get; set; }
        public object customfield_18432 { get; set; }
        public float? customfield_24714 { get; set; }
        public object customfield_18433 { get; set; }
        public object customfield_24718 { get; set; }
        public object customfield_24719 { get; set; }
        public Customfield_31009 customfield_31009 { get; set; }
        public object customfield_31008 { get; set; }
        public object customfield_18434 { get; set; }
        public object customfield_31005 { get; set; }
        public object customfield_31004 { get; set; }
        public object customfield_31007 { get; set; }
        public object customfield_31006 { get; set; }
        public object customfield_31012 { get; set; }
        public object customfield_31011 { get; set; }
        public string customfield_31013 { get; set; }
        public object customfield_31010 { get; set; }
        public object customfield_24720 { get; set; }
        public object customfield_26900 { get; set; }
        public object customfield_24721 { get; set; }
        public object customfield_24722 { get; set; }
        public object customfield_26902 { get; set; }
        public object customfield_24723 { get; set; }
        public object customfield_18420 { get; set; }
        public object customfield_18421 { get; set; }
        public object customfield_18422 { get; set; }
        public object customfield_26903 { get; set; }
        public object customfield_24726 { get; set; }
        public object customfield_24727 { get; set; }
        public object customfield_24728 { get; set; }
        public object customfield_24729 { get; set; }
        public object customfield_18427 { get; set; }
        public object customfield_18428 { get; set; }
        public object customfield_18429 { get; set; }
        public object customfield_18423 { get; set; }
        public object customfield_18424 { get; set; }
        public string customfield_18425 { get; set; }
        public object customfield_33202 { get; set; }
        public object customfield_33203 { get; set; }
        public object customfield_33200 { get; set; }
        public object customfield_33201 { get; set; }
        public object customfield_23400 { get; set; }
        public object customfield_23401 { get; set; }
        public object customfield_18410 { get; set; }
        public object customfield_24736 { get; set; }
        public object customfield_24737 { get; set; }
        public object customfield_18416 { get; set; }
        public object customfield_18417 { get; set; }
        public object customfield_18418 { get; set; }
        public string customfield_33208 { get; set; }
        public object customfield_18419 { get; set; }
        public object customfield_33209 { get; set; }
        public object customfield_33206 { get; set; }
        public object customfield_18413 { get; set; }
        public object customfield_33207 { get; set; }
        public object customfield_18414 { get; set; }
        public object customfield_33204 { get; set; }
        public object customfield_18415 { get; set; }
        public object customfield_33205 { get; set; }
        public object customfield_33213 { get; set; }
        public object customfield_33214 { get; set; }
        public object customfield_33211 { get; set; }
        public object customfield_33212 { get; set; }
        public object customfield_18409 { get; set; }
        public object customfield_33210 { get; set; }
        public object customfield_22902 { get; set; }
        public object customfield_22901 { get; set; }
        public object customfield_18405 { get; set; }
        public object customfield_18406 { get; set; }
        public object customfield_18407 { get; set; }
        public object customfield_18408 { get; set; }
        public object customfield_18404 { get; set; }
        public object customfield_25601 { get; set; }
        public object customfield_25602 { get; set; }
        public object customfield_31841 { get; set; }
        public object customfield_31840 { get; set; }
        public object customfield_31843 { get; set; }
        public object customfield_31842 { get; set; }
        public object customfield_27350 { get; set; }
        public object customfield_28200 { get; set; }
        public object customfield_27351 { get; set; }
        public object customfield_28201 { get; set; }
        public object customfield_28202 { get; set; }
        public object customfield_28203 { get; set; }
        public object customfield_10100 { get; set; }
        public Status status { get; set; }
        public object customfield_20367 { get; set; }
        public object customfield_20365 { get; set; }
        public object customfield_20366 { get; set; }
        public object customfield_21212 { get; set; }
        public object customfield_20363 { get; set; }
        public object customfield_21211 { get; set; }
        public object customfield_21210 { get; set; }
        public object customfield_20364 { get; set; }
        public object customfield_20361 { get; set; }
        public object customfield_20362 { get; set; }
        public object customfield_20360 { get; set; }
        public object customfield_14913 { get; set; }
        public object customfield_14911 { get; set; }
        public object customfield_11407 { get; set; }
        public object customfield_14916 { get; set; }
        public object customfield_21209 { get; set; }
        public object customfield_21208 { get; set; }
        public object customfield_21207 { get; set; }
        public object customfield_20358 { get; set; }
        public object customfield_20359 { get; set; }
        public object customfield_21205 { get; set; }
        public object customfield_21204 { get; set; }
        public object customfield_20356 { get; set; }
        public object customfield_20357 { get; set; }
        public object customfield_21203 { get; set; }
        public object customfield_21202 { get; set; }
        public string customfield_20354 { get; set; }
        public object customfield_21201 { get; set; }
        public object customfield_20355 { get; set; }
        public object customfield_21200 { get; set; }
        public object customfield_20352 { get; set; }
        public object customfield_20353 { get; set; }
        public object customfield_20350 { get; set; }
        public object customfield_31409 { get; set; }
        public object customfield_20351 { get; set; }
        public object customfield_31408 { get; set; }
        public object timespent { get; set; }
        public object customfield_31404 { get; set; }
        public object customfield_31407 { get; set; }
        public object customfield_31406 { get; set; }
        public object customfield_31401 { get; set; }
        public object customfield_14910 { get; set; }
        public object customfield_31400 { get; set; }
        public object customfield_31403 { get; set; }
        public object customfield_31402 { get; set; }
        public object customfield_31410 { get; set; }
        public object customfield_14906 { get; set; }
        public object customfield_14907 { get; set; }
        public object customfield_14905 { get; set; }
        public object customfield_20349 { get; set; }
        public object customfield_20348 { get; set; }
        public object customfield_20345 { get; set; }
        public object customfield_20343 { get; set; }
        public object customfield_20341 { get; set; }
        public object customfield_20342 { get; set; }
        public object customfield_20340 { get; set; }
        public object customfield_31419 { get; set; }
        public object customfield_31416 { get; set; }
        public object customfield_31415 { get; set; }
        public object customfield_31418 { get; set; }
        public object customfield_31417 { get; set; }
        public object customfield_31412 { get; set; }
        public object customfield_31411 { get; set; }
        public object customfield_31414 { get; set; }
        public object customfield_31413 { get; set; }
        public object customfield_31421 { get; set; }
        public object customfield_31420 { get; set; }
        public object customfield_29100 { get; set; }
        public object customfield_29101 { get; set; }
        public object customfield_20338 { get; set; }
        public object customfield_20336 { get; set; }
        public object customfield_20337 { get; set; }
        public object customfield_20334 { get; set; }
        public object customfield_20335 { get; set; }
        public object customfield_18012 { get; set; }
        public object customfield_20332 { get; set; }
        public object customfield_20333 { get; set; }
        public object customfield_18013 { get; set; }
        public object customfield_23800 { get; set; }
        public object customfield_18014 { get; set; }
        public object customfield_20330 { get; set; }
        public object customfield_20331 { get; set; }
        public object customfield_18499 { get; set; }
        public object customfield_18015 { get; set; }
        public object customfield_18492 { get; set; }
        public object customfield_18493 { get; set; }
        public object customfield_18494 { get; set; }
        public object customfield_18010 { get; set; }
        public object customfield_18495 { get; set; }
        public object customfield_18011 { get; set; }
        public object customfield_31427 { get; set; }
        public object customfield_33606 { get; set; }
        public object customfield_31426 { get; set; }
        public object customfield_31429 { get; set; }
        public object customfield_33604 { get; set; }
        public object customfield_31428 { get; set; }
        public object customfield_33605 { get; set; }
        public object customfield_18016 { get; set; }
        public object customfield_31423 { get; set; }
        public object customfield_33602 { get; set; }
        public object customfield_31422 { get; set; }
        public object customfield_31425 { get; set; }
        public object customfield_33600 { get; set; }
        public object customfield_33601 { get; set; }
        public object customfield_31430 { get; set; }
        public object customfield_12703 { get; set; }
        public object customfield_31432 { get; set; }
        public object customfield_12702 { get; set; }
        public object customfield_31431 { get; set; }
        public object customfield_30101 { get; set; }
        public object customfield_12705 { get; set; }
        public object customfield_12704 { get; set; }
        public object customfield_20329 { get; set; }
        public object customfield_22508 { get; set; }
        public object customfield_22507 { get; set; }
        public object customfield_20327 { get; set; }
        public object customfield_22506 { get; set; }
        public object customfield_18490 { get; set; }
        public object customfield_18491 { get; set; }
        public object customfield_20328 { get; set; }
        public string customfield_22505 { get; set; }
        public object customfield_20325 { get; set; }
        public string customfield_22504 { get; set; }
        public object customfield_20326 { get; set; }
        public object customfield_22503 { get; set; }
        public object customfield_22502 { get; set; }
        public object customfield_20323 { get; set; }
        public string customfield_22501 { get; set; }
        public object customfield_20324 { get; set; }
        public object customfield_22500 { get; set; }
        public object customfield_18486 { get; set; }
        public object customfield_18487 { get; set; }
        public object customfield_18003 { get; set; }
        public object customfield_18004 { get; set; }
        public object customfield_18481 { get; set; }
        public object customfield_18009 { get; set; }
        public object customfield_31438 { get; set; }
        public object customfield_30106 { get; set; }
        public object customfield_31437 { get; set; }
        public object customfield_31439 { get; set; }
        public object customfield_30109 { get; set; }
        public object customfield_31434 { get; set; }
        public object customfield_30102 { get; set; }
        public object customfield_18006 { get; set; }
        public object customfield_31433 { get; set; }
        public object customfield_30103 { get; set; }
        public object customfield_31436 { get; set; }
        public object customfield_30104 { get; set; }
        public object customfield_31435 { get; set; }
        public object customfield_30105 { get; set; }
        public object customfield_31441 { get; set; }
        public object customfield_30110 { get; set; }
        public object customfield_31440 { get; set; }
        public object customfield_30111 { get; set; }
        public object customfield_31443 { get; set; }
        public object customfield_30112 { get; set; }
        public object customfield_31442 { get; set; }
        public object customfield_20318 { get; set; }
        public object customfield_20319 { get; set; }
        public object customfield_20316 { get; set; }
        public object customfield_20317 { get; set; }
        public object customfield_18480 { get; set; }
        public object customfield_20314 { get; set; }
        public object customfield_20315 { get; set; }
        public object customfield_20312 { get; set; }
        public object customfield_20313 { get; set; }
        public object customfield_30917 { get; set; }
        public object customfield_26418 { get; set; }
        public object customfield_30918 { get; set; }
        public Customfield_26417 customfield_26417 { get; set; }
        public object customfield_30919 { get; set; }
        public Customfield_26419 customfield_26419 { get; set; }
        public object customfield_30913 { get; set; }
        public object customfield_15760 { get; set; }
        public object customfield_30914 { get; set; }
        public object customfield_30915 { get; set; }
        public object customfield_30916 { get; set; }
        public object customfield_15763 { get; set; }
        public object customfield_14433 { get; set; }
        public object customfield_15764 { get; set; }
        public object customfield_16610 { get; set; }
        public object customfield_30910 { get; set; }
        public object customfield_14430 { get; set; }
        public object customfield_15761 { get; set; }
        public object customfield_30911 { get; set; }
        public object customfield_30912 { get; set; }
        public object customfield_15762 { get; set; }
        public object customfield_14436 { get; set; }
        public object customfield_15767 { get; set; }
        public object customfield_14437 { get; set; }
        public object customfield_15768 { get; set; }
        public object customfield_14434 { get; set; }
        public object customfield_15765 { get; set; }
        public object customfield_14435 { get; set; }
        public object customfield_14429 { get; set; }
        public object customfield_16608 { get; set; }
        public object customfield_15758 { get; set; }
        public object customfield_16606 { get; set; }
        public Customfield_15759 customfield_15759 { get; set; }
        public object customfield_28601 { get; set; }
        public object customfield_26420 { get; set; }
        public object customfield_28602 { get; set; }
        public object customfield_28603 { get; set; }
        public object customfield_28609 { get; set; }
        public object customfield_30929 { get; set; }
        public object customfield_30924 { get; set; }
        public object customfield_30925 { get; set; }
        public object customfield_30926 { get; set; }
        public object customfield_30927 { get; set; }
        public object customfield_15752 { get; set; }
        public object customfield_30920 { get; set; }
        public object customfield_15753 { get; set; }
        public object customfield_30921 { get; set; }
        public object customfield_30922 { get; set; }
        public object customfield_14420 { get; set; }
        public object customfield_30923 { get; set; }
        public Customfield_15757 customfield_15757 { get; set; }
        public object customfield_15754 { get; set; }
        public object customfield_14424 { get; set; }
        public Customfield_15755 customfield_15755 { get; set; }
        public object customfield_14418 { get; set; }
        public object customfield_15749 { get; set; }
        public object customfield_14417 { get; set; }
        public object customfield_28611 { get; set; }
        public object customfield_28612 { get; set; }
        public object customfield_28610 { get; set; }
        public object customfield_28615 { get; set; }
        public object customfield_28616 { get; set; }
        public object customfield_28619 { get; set; }
        public object customfield_30939 { get; set; }
        public object customfield_30935 { get; set; }
        public object customfield_30936 { get; set; }
        public object customfield_30937 { get; set; }
        public object customfield_30938 { get; set; }
        public object customfield_14410 { get; set; }
        public object customfield_30931 { get; set; }
        public object customfield_30932 { get; set; }
        public object customfield_30933 { get; set; }
        public object customfield_15740 { get; set; }
        public object customfield_30934 { get; set; }
        public object customfield_15745 { get; set; }
        public object customfield_15743 { get; set; }
        public object customfield_30930 { get; set; }
        public object customfield_14406 { get; set; }
        public object customfield_15737 { get; set; }
        public object customfield_28622 { get; set; }
        public object customfield_28623 { get; set; }
        public object customfield_28620 { get; set; }
        public object customfield_28621 { get; set; }
        public object customfield_28626 { get; set; }
        public object customfield_28627 { get; set; }
        public object customfield_28628 { get; set; }
        public object customfield_28629 { get; set; }
        public object customfield_22021 { get; set; }
        public object customfield_15730 { get; set; }
        public object customfield_30942 { get; set; }
        public object customfield_15731 { get; set; }
        public object customfield_30943 { get; set; }
        public string customfield_14403 { get; set; }
        public object customfield_30940 { get; set; }
        public object customfield_30941 { get; set; }
        public object customfield_15727 { get; set; }
        public object customfield_15728 { get; set; }
        public string customfield_15725 { get; set; }
        public object customfield_15726 { get; set; }
        public object customfield_28630 { get; set; }
        public object customfield_15729 { get; set; }
        public object customfield_27300 { get; set; }
        public object[] customfield_28634 { get; set; }
        public Progress progress { get; set; }
        public object customfield_28632 { get; set; }
        public object customfield_28637 { get; set; }
        public object customfield_22019 { get; set; }
        public object customfield_27307 { get; set; }
        public object customfield_28635 { get; set; }
        public object customfield_31809 { get; set; }
        public object customfield_31808 { get; set; }
        public object customfield_22012 { get; set; }
        public object customfield_31805 { get; set; }
        public object customfield_22011 { get; set; }
        public object customfield_31804 { get; set; }
        public object customfield_31807 { get; set; }
        public object customfield_31806 { get; set; }
        public object customfield_31801 { get; set; }
        public object customfield_15720 { get; set; }
        public object customfield_31800 { get; set; }
        public Project project { get; set; }
        public object customfield_31803 { get; set; }
        public object customfield_31802 { get; set; }
        public object customfield_15723 { get; set; }
        public object customfield_15724 { get; set; }
        public string customfield_15721 { get; set; }
        public object customfield_17900 { get; set; }
        public object customfield_30952 { get; set; }
        public object customfield_12205 { get; set; }
        public object customfield_15714 { get; set; }
        public object customfield_28641 { get; set; }
        public object customfield_27310 { get; set; }
        public object customfield_27312 { get; set; }
        public object customfield_28644 { get; set; }
        public object customfield_28645 { get; set; }
        public object customfield_27311 { get; set; }
        public object customfield_27314 { get; set; }
        public object customfield_28642 { get; set; }
        public object customfield_27313 { get; set; }
        public object customfield_28643 { get; set; }
        public object customfield_22009 { get; set; }
        public object customfield_27316 { get; set; }
        public object customfield_28648 { get; set; }
        public object customfield_22008 { get; set; }
        public object customfield_27315 { get; set; }
        public object customfield_22007 { get; set; }
        public object customfield_22006 { get; set; }
        public object customfield_27317 { get; set; }
        public object customfield_28647 { get; set; }
        public object customfield_22005 { get; set; }
        public object customfield_22004 { get; set; }
        public object customfield_27319 { get; set; }
        public object customfield_31819 { get; set; }
        public object customfield_22003 { get; set; }
        public object customfield_22002 { get; set; }
        public object customfield_22001 { get; set; }
        public object customfield_31816 { get; set; }
        public object customfield_31815 { get; set; }
        public object customfield_31818 { get; set; }
        public object customfield_31817 { get; set; }
        public object customfield_31812 { get; set; }
        public object customfield_31811 { get; set; }
        public object customfield_31814 { get; set; }
        public object customfield_31813 { get; set; }
        public object customfield_15713 { get; set; }
        public object customfield_12204 { get; set; }
        public object customfield_15710 { get; set; }
        public object customfield_31810 { get; set; }
        public object customfield_12203 { get; set; }
        public object customfield_10016 { get; set; }
        public object customfield_15705 { get; set; }
        public object customfield_15706 { get; set; }
        public object customfield_15704 { get; set; }
        public object customfield_15707 { get; set; }
        public object customfield_15708 { get; set; }
        public object customfield_31827 { get; set; }
        public object customfield_31826 { get; set; }
        public object customfield_31829 { get; set; }
        public object customfield_31828 { get; set; }
        public string customfield_31823 { get; set; }
        public object customfield_31822 { get; set; }
        public object customfield_10010 { get; set; }
        public object customfield_31825 { get; set; }
        public object customfield_10011 { get; set; }
        public object customfield_31824 { get; set; }
        public object customfield_10012 { get; set; }
        public object customfield_15701 { get; set; }
        public object customfield_10013 { get; set; }
        public object customfield_14855 { get; set; }
        public object customfield_10014 { get; set; }
        public object customfield_31821 { get; set; }
        public object customfield_10015 { get; set; }
        public object customfield_15700 { get; set; }
        public object customfield_31820 { get; set; }
        public object customfield_10005 { get; set; }
        public object customfield_14847 { get; set; }
        public object customfield_10007 { get; set; }
        public object customfield_10008 { get; set; }
        public object customfield_10009 { get; set; }
        public object customfield_27330 { get; set; }
        public object customfield_27334 { get; set; }
        public object customfield_27333 { get; set; }
        public object customfield_27336 { get; set; }
        public object customfield_27335 { get; set; }
        public object customfield_27338 { get; set; }
        public object customfield_27337 { get; set; }
        public object customfield_27339 { get; set; }
        public string summary { get; set; }
        public object customfield_21132 { get; set; }
        public object customfield_31838 { get; set; }
        public object customfield_21131 { get; set; }
        public object customfield_31837 { get; set; }
        public object customfield_21130 { get; set; }
        public object customfield_31839 { get; set; }
        public object customfield_30502 { get; set; }
        public object customfield_31834 { get; set; }
        public object customfield_14840 { get; set; }
        public object customfield_31833 { get; set; }
        public object customfield_30503 { get; set; }
        public object customfield_31836 { get; set; }
        public object customfield_30504 { get; set; }
        public object customfield_31835 { get; set; }
        public object customfield_10001 { get; set; }
        public object customfield_31830 { get; set; }
        public Customfield_10002 customfield_10002 { get; set; }
        public object customfield_10003 { get; set; }
        public object customfield_14841 { get; set; }
        public object customfield_30500 { get; set; }
        public object customfield_10004 { get; set; }
        public object customfield_30501 { get; set; }
        public object customfield_31831 { get; set; }
        public object customfield_14834 { get; set; }
        public object customfield_14835 { get; set; }
        public object customfield_27341 { get; set; }
        public object customfield_27340 { get; set; }
        public object customfield_27343 { get; set; }
        public object customfield_27345 { get; set; }
        public object customfield_27346 { get; set; }
        public object customfield_21129 { get; set; }
        public object customfield_27349 { get; set; }
        public object customfield_21128 { get; set; }
        public object customfield_21126 { get; set; }
        public object customfield_10900 { get; set; }
        public object customfield_20703 { get; set; }
        public object customfield_20701 { get; set; }
        public object customfield_20700 { get; set; }
        public object customfield_25500 { get; set; }
        public object customfield_25501 { get; set; }
        public object customfield_25502 { get; set; }
        public object customfield_25503 { get; set; }
        public object customfield_25504 { get; set; }
        public object customfield_19700 { get; set; }
        public object customfield_19701 { get; set; }
        public object customfield_19702 { get; set; }
        public object customfield_15330 { get; set; }
        public object customfield_14003 { get; set; }
        public object customfield_14001 { get; set; }
        public object customfield_14002 { get; set; }
        public object customfield_15329 { get; set; }
        public object customfield_27700 { get; set; }
        public object customfield_27703 { get; set; }
        public object customfield_27705 { get; set; }
        public object customfield_27704 { get; set; }
        public object customfield_27706 { get; set; }
        public object customfield_15323 { get; set; }
        public object customfield_15324 { get; set; }
        public object customfield_15321 { get; set; }
        public object customfield_15327 { get; set; }
        public object customfield_15328 { get; set; }
        public object customfield_15325 { get; set; }
        public object customfield_15326 { get; set; }
        public object customfield_15318 { get; set; }
        public object customfield_15319 { get; set; }
        public object customfield_24200 { get; set; }
        public object customfield_15313 { get; set; }
        public object customfield_15317 { get; set; }
        public object customfield_18820 { get; set; }
        public object customfield_18816 { get; set; }
        public object customfield_18817 { get; set; }
        public object customfield_18818 { get; set; }
        public object customfield_29902 { get; set; }
        public object customfield_29903 { get; set; }
        public object customfield_29900 { get; set; }
        public object customfield_29901 { get; set; }
        public object customfield_29906 { get; set; }
        public object customfield_29907 { get; set; }
        public object customfield_29904 { get; set; }
        public object customfield_29905 { get; set; }
        public object customfield_29908 { get; set; }
        public object customfield_29909 { get; set; }
        public object customfield_15301 { get; set; }
        public object customfield_18812 { get; set; }
        public object customfield_15302 { get; set; }
        public object customfield_18813 { get; set; }
        public object customfield_18815 { get; set; }
        public object customfield_15305 { get; set; }
        public object customfield_15303 { get; set; }
        public object customfield_18810 { get; set; }
        public object customfield_18811 { get; set; }
        public object customfield_18809 { get; set; }
        public object customfield_18806 { get; set; }
        public object customfield_18807 { get; set; }
        public object customfield_18808 { get; set; }
        public object customfield_29910 { get; set; }
        public object customfield_26401 { get; set; }
        public Customfield_26400 customfield_26400 { get; set; }
        public object customfield_29913 { get; set; }
        public object customfield_26403 { get; set; }
        public Customfield_26402 customfield_26402 { get; set; }
        public object customfield_29911 { get; set; }
        public Customfield_26405 customfield_26405 { get; set; }
        public string customfield_29912 { get; set; }
        public object customfield_26404 { get; set; }
        public object customfield_30906 { get; set; }
        public object customfield_26407 { get; set; }
        public object customfield_30907 { get; set; }
        public object customfield_26406 { get; set; }
        public object customfield_30908 { get; set; }
        public object customfield_26409 { get; set; }
        public object customfield_30909 { get; set; }
        public Customfield_26408 customfield_26408 { get; set; }
        public object customfield_15770 { get; set; }
        public object customfield_30902 { get; set; }
        public object customfield_30903 { get; set; }
        public object customfield_30904 { get; set; }
        public object customfield_30905 { get; set; }
        public object customfield_14443 { get; set; }
        public object customfield_15774 { get; set; }
        public Customfield_15775 customfield_15775 { get; set; }
        public object customfield_14441 { get; set; }
        public object customfield_30900 { get; set; }
        public object customfield_18804 { get; set; }
        public object customfield_15773 { get; set; }
        public object customfield_30901 { get; set; }
        public object customfield_14447 { get; set; }
        public object customfield_15778 { get; set; }
        public object customfield_14445 { get; set; }
        public object customfield_15776 { get; set; }
        public object customfield_18800 { get; set; }
        public object customfield_15777 { get; set; }
        public object customfield_14439 { get; set; }
        public object customfield_26410 { get; set; }
        public object customfield_26412 { get; set; }
        public Customfield_26411 customfield_26411 { get; set; }
        public object customfield_26414 { get; set; }
        public Customfield_26413 customfield_26413 { get; set; }
        public object customfield_26416 { get; set; }
        public Customfield_26415 customfield_26415 { get; set; }
        public string customfield_21521 { get; set; }
        public object customfield_18353 { get; set; }
        public object customfield_18354 { get; set; }
        public object customfield_21520 { get; set; }
        public object customfield_19201 { get; set; }
        public object customfield_19202 { get; set; }
        public object customfield_23702 { get; set; }
        public object customfield_19203 { get; set; }
        public object customfield_23703 { get; set; }
        public object customfield_23704 { get; set; }
        public object customfield_18350 { get; set; }
        public object customfield_23705 { get; set; }
        public object customfield_18351 { get; set; }
        public object customfield_23706 { get; set; }
        public object customfield_19208 { get; set; }
        public object customfield_31328 { get; set; }
        public object customfield_19209 { get; set; }
        public object[] customfield_31327 { get; set; }
        public object customfield_31329 { get; set; }
        public object customfield_19204 { get; set; }
        public object customfield_31324 { get; set; }
        public Resolution resolution { get; set; }
        public object customfield_31323 { get; set; }
        public object customfield_11720 { get; set; }
        public object customfield_31326 { get; set; }
        public object customfield_19207 { get; set; }
        public object customfield_31325 { get; set; }
        public object customfield_11711 { get; set; }
        public object customfield_31331 { get; set; }
        public object customfield_30000 { get; set; }
        public object customfield_31330 { get; set; }
        public object customfield_30001 { get; set; }
        public object customfield_31333 { get; set; }
        public object customfield_31332 { get; set; }
        public object customfield_30002 { get; set; }
        public object customfield_11714 { get; set; }
        public object customfield_21519 { get; set; }
        public object customfield_11719 { get; set; }
        public object customfield_11718 { get; set; }
        public object customfield_21516 { get; set; }
        public object customfield_21514 { get; set; }
        public object customfield_21513 { get; set; }
        public object customfield_21512 { get; set; }
        public object customfield_23710 { get; set; }
        public object customfield_17010 { get; set; }
        public object customfield_18344 { get; set; }
        public object customfield_23713 { get; set; }
        public string customfield_18345 { get; set; }
        public object customfield_17014 { get; set; }
        public object customfield_17013 { get; set; }
        public object customfield_23716 { get; set; }
        public object customfield_17012 { get; set; }
        public object customfield_17011 { get; set; }
        public object customfield_23718 { get; set; }
        public object customfield_30007 { get; set; }
        public object customfield_31339 { get; set; }
        public object customfield_31338 { get; set; }
        public object customfield_30008 { get; set; }
        public object customfield_30009 { get; set; }
        public object customfield_17015 { get; set; }
        public object customfield_18346 { get; set; }
        public object customfield_30003 { get; set; }
        public object customfield_31335 { get; set; }
        public object customfield_18347 { get; set; }
        public object customfield_30004 { get; set; }
        public object customfield_31334 { get; set; }
        public object customfield_18348 { get; set; }
        public object customfield_30005 { get; set; }
        public object customfield_18349 { get; set; }
        public object customfield_30006 { get; set; }
        public object customfield_11700 { get; set; }
        public object customfield_31342 { get; set; }
        public object customfield_31341 { get; set; }
        public object customfield_11701 { get; set; }
        public object customfield_31343 { get; set; }
        public object customfield_11703 { get; set; }
        public object customfield_31340 { get; set; }
        public object customfield_11705 { get; set; }
        public object customfield_21508 { get; set; }
        public object customfield_21507 { get; set; }
        public object customfield_21506 { get; set; }
        public object customfield_21505 { get; set; }
        public object customfield_21504 { get; set; }
        public object customfield_21503 { get; set; }
        public object customfield_23720 { get; set; }
        public object customfield_21500 { get; set; }
        public object customfield_23721 { get; set; }
        public object customfield_23722 { get; set; }
        public object customfield_23723 { get; set; }
        public object customfield_18333 { get; set; }
        public object customfield_25902 { get; set; }
        public object customfield_23724 { get; set; }
        public object customfield_18334 { get; set; }
        public object customfield_25903 { get; set; }
        public object customfield_23725 { get; set; }
        public object customfield_17003 { get; set; }
        public object customfield_17002 { get; set; }
        public object customfield_18330 { get; set; }
        public object customfield_31349 { get; set; }
        public object customfield_18335 { get; set; }
        public object customfield_18336 { get; set; }
        public object customfield_31345 { get; set; }
        public object customfield_17009 { get; set; }
        public object customfield_18337 { get; set; }
        public object customfield_31348 { get; set; }
        public object customfield_18338 { get; set; }
        public object customfield_17008 { get; set; }
        public object customfield_31347 { get; set; }
        public object customfield_32200 { get; set; }
        public object customfield_32202 { get; set; }
        public object customfield_32201 { get; set; }
        public object customfield_22829 { get; set; }
        public object customfield_22828 { get; set; }
        public object[] customfield_31350 { get; set; }
        public object customfield_22821 { get; set; }
        public object customfield_22820 { get; set; }
        public object customfield_18320 { get; set; }
        public object customfield_18321 { get; set; }
        public string customfield_18322 { get; set; }
        public object customfield_18323 { get; set; }
        public string customfield_18328 { get; set; }
        public object customfield_32208 { get; set; }
        public object customfield_18329 { get; set; }
        public object customfield_32207 { get; set; }
        public object customfield_18324 { get; set; }
        public object customfield_32204 { get; set; }
        public object customfield_18325 { get; set; }
        public object customfield_32203 { get; set; }
        public object customfield_18326 { get; set; }
        public object customfield_32206 { get; set; }
        public object customfield_18327 { get; set; }
        public object customfield_32205 { get; set; }
        public object customfield_32211 { get; set; }
        public object customfield_32210 { get; set; }
        public object customfield_32213 { get; set; }
        public object customfield_32212 { get; set; }
        public object customfield_22819 { get; set; }
        public object customfield_22818 { get; set; }
        public object customfield_22815 { get; set; }
        public object customfield_22814 { get; set; }
        public object customfield_22813 { get; set; }
        public object customfield_22812 { get; set; }
        public object customfield_22810 { get; set; }
        public Issuetype issuetype { get; set; }
        public Customfield_18311 customfield_18311 { get; set; }
        public object customfield_18796 { get; set; }
        public object customfield_18312 { get; set; }
        public string customfield_18791 { get; set; }
        public string customfield_18317 { get; set; }
        public object customfield_32219 { get; set; }
        public object customfield_18318 { get; set; }
        public object customfield_32218 { get; set; }
        public object customfield_18319 { get; set; }
        public object customfield_18313 { get; set; }
        public object customfield_32215 { get; set; }
        public object customfield_18314 { get; set; }
        public object customfield_32214 { get; set; }
        public object customfield_18315 { get; set; }
        public object customfield_32217 { get; set; }
        public object customfield_18316 { get; set; }
        public object customfield_32216 { get; set; }
        public object customfield_32221 { get; set; }
        public object customfield_22809 { get; set; }
        public object customfield_22808 { get; set; }
        public object customfield_22807 { get; set; }
        public object customfield_32220 { get; set; }
        public object customfield_22806 { get; set; }
        public object customfield_22805 { get; set; }
        public object customfield_22804 { get; set; }
        public object customfield_22803 { get; set; }
        public object customfield_22802 { get; set; }
        public object customfield_24600 { get; set; }
        public object customfield_24601 { get; set; }
        public object customfield_24602 { get; set; }
        public object customfield_24603 { get; set; }
        public object customfield_24604 { get; set; }
        public string customfield_18785 { get; set; }
        public object customfield_24605 { get; set; }
        public object customfield_24606 { get; set; }
        public object customfield_16122 { get; set; }
        public object customfield_24607 { get; set; }
        public object customfield_16121 { get; set; }
        public object customfield_24608 { get; set; }
        public object customfield_16120 { get; set; }
        public object customfield_18308 { get; set; }
        public string customfield_18788 { get; set; }
        public object customfield_18771 { get; set; }
        public string customfield_18774 { get; set; }
        public string customfield_16110 { get; set; }
        public object customfield_16116 { get; set; }
        public string customfield_16113 { get; set; }
        public string customfield_18775 { get; set; }
        public object customfield_18776 { get; set; }
        public object customfield_16118 { get; set; }
        public object customfield_16117 { get; set; }
        public object customfield_20606 { get; set; }
        public object customfield_20607 { get; set; }
        public object customfield_20605 { get; set; }
        public object customfield_20600 { get; set; }
        public object customfield_20601 { get; set; }
        public object customfield_26801 { get; set; }
        public object customfield_18760 { get; set; }
        public object customfield_26803 { get; set; }
        public object customfield_18761 { get; set; }
        public object customfield_26802 { get; set; }
        public object customfield_18762 { get; set; }
        public Customfield_26805[] customfield_26805 { get; set; }
        public object customfield_18763 { get; set; }
        public object customfield_19610 { get; set; }
        public object customfield_16101 { get; set; }
        public Customfield_26807 customfield_26807 { get; set; }
        public Customfield_26806[] customfield_26806 { get; set; }
        public object customfield_19615 { get; set; }
        public object customfield_16104 { get; set; }
        public object customfield_19616 { get; set; }
        public object customfield_19611 { get; set; }
        public object customfield_16109 { get; set; }
        public object customfield_18764 { get; set; }
        public object customfield_19613 { get; set; }
        public object customfield_18766 { get; set; }
        public object customfield_16106 { get; set; }
        public object customfield_19614 { get; set; }
        public object customfield_33103 { get; set; }
        public object environment { get; set; }
        public object customfield_33101 { get; set; }
        public object customfield_33102 { get; set; }
        public object customfield_19608 { get; set; }
        public object customfield_19609 { get; set; }
        public object customfield_33100 { get; set; }
        public object customfield_21125 { get; set; }
        public object customfield_21124 { get; set; }
        public object customfield_23302 { get; set; }
        public object customfield_21123 { get; set; }
        public object customfield_29409 { get; set; }
        public object customfield_23301 { get; set; }
        public object customfield_21122 { get; set; }
        public object customfield_23300 { get; set; }
        public object customfield_21121 { get; set; }
        public object customfield_21120 { get; set; }
        public object customfield_11320 { get; set; }
        public object customfield_11321 { get; set; }
        public object customfield_14832 { get; set; }
        public object customfield_31720 { get; set; }
        public object customfield_11322 { get; set; }
        public object customfield_11323 { get; set; }
        public object customfield_14830 { get; set; }
        public object customfield_14831 { get; set; }
        public object customfield_11314 { get; set; }
        public object customfield_14825 { get; set; }
        public object customfield_14826 { get; set; }
        public object customfield_14823 { get; set; }
        public object customfield_14829 { get; set; }
        public object customfield_29410 { get; set; }
        public object customfield_14827 { get; set; }
        public object customfield_14828 { get; set; }
        public object customfield_29412 { get; set; }
        public object customfield_29413 { get; set; }
        public object customfield_21118 { get; set; }
        public object customfield_21117 { get; set; }
        public object customfield_21116 { get; set; }
        public object customfield_21115 { get; set; }
        public object customfield_21114 { get; set; }
        public object customfield_21113 { get; set; }
        public object customfield_30403 { get; set; }
        public object customfield_11310 { get; set; }
        public object customfield_11311 { get; set; }
        public object customfield_14822 { get; set; }
        public object customfield_11312 { get; set; }
        public object customfield_11313 { get; set; }
        public object customfield_14820 { get; set; }
        public object customfield_30402 { get; set; }
        public object customfield_11303 { get; set; }
        public object customfield_11304 { get; set; }
        public object customfield_14815 { get; set; }
        public object customfield_11305 { get; set; }
        public object customfield_11306 { get; set; }
        public object customfield_14813 { get; set; }
        public object customfield_14818 { get; set; }
        public object customfield_11308 { get; set; }
        public object customfield_11309 { get; set; }
        public object customfield_14816 { get; set; }
        public object customfield_14817 { get; set; }
        public object customfield_21108 { get; set; }
        public object customfield_21107 { get; set; }
        public object customfield_14810 { get; set; }
        public object customfield_11300 { get; set; }
        public object customfield_11302 { get; set; }
        public object customfield_14803 { get; set; }
        public object customfield_14804 { get; set; }
        public object customfield_14802 { get; set; }
        public object customfield_14807 { get; set; }
        public object customfield_28101 { get; set; }
        public object customfield_28102 { get; set; }
        public Customfield_14805 customfield_14805 { get; set; }
        public Customfield_14806 customfield_14806 { get; set; }
        public object customfield_28109 { get; set; }
        public object customfield_28107 { get; set; }
        public object customfield_22420 { get; set; }
        public object customfield_32608 { get; set; }
        public object customfield_32607 { get; set; }
        public object customfield_19253 { get; set; }
        public object customfield_32609 { get; set; }
        public object customfield_32604 { get; set; }
        public object customfield_32603 { get; set; }
        public object customfield_32606 { get; set; }
        public object customfield_32605 { get; set; }
        public object customfield_32600 { get; set; }
        public object customfield_32602 { get; set; }
        public object customfield_32601 { get; set; }
        public object customfield_28112 { get; set; }
        public object customfield_28110 { get; set; }
        public Customfield_19250[] customfield_19250 { get; set; }
        public object customfield_28115 { get; set; }
        public object customfield_22415 { get; set; }
        public object customfield_22414 { get; set; }
        public object customfield_22413 { get; set; }
        public Customfield_22411[] customfield_22411 { get; set; }
        public object customfield_22410 { get; set; }
        public string customfield_20231 { get; set; }
        public object customfield_20232 { get; set; }
        public object customfield_32611 { get; set; }
        public object customfield_32610 { get; set; }
        public string customfield_32613 { get; set; }
        public string customfield_32612 { get; set; }
        public object customfield_22409 { get; set; }
        public Customfield_22408 customfield_22408 { get; set; }
        public int workratio { get; set; }
        public object customfield_20228 { get; set; }
        public string customfield_22407 { get; set; }
        public string customfield_20229 { get; set; }
        public string customfield_22406 { get; set; }
        public object customfield_20226 { get; set; }
        public object customfield_20227 { get; set; }
        public object customfield_22403 { get; set; }
        public object customfield_20224 { get; set; }
        public string customfield_28129 { get; set; }
        public object customfield_20225 { get; set; }
        public object customfield_22402 { get; set; }
        public object customfield_20222 { get; set; }
        public object customfield_22401 { get; set; }
        public object customfield_22400 { get; set; }
        public object customfield_20223 { get; set; }
        public object customfield_20220 { get; set; }
        public object customfield_19236 { get; set; }
        public object customfield_20221 { get; set; }
        public object customfield_19237 { get; set; }
        public object customfield_19238 { get; set; }
        public object customfield_11744 { get; set; }
        public object customfield_28130 { get; set; }
        public object customfield_11743 { get; set; }
        public object customfield_28131 { get; set; }
        public object customfield_11746 { get; set; }
        public object customfield_31300 { get; set; }
        public object customfield_11745 { get; set; }
        public object customfield_28134 { get; set; }
        public object customfield_28132 { get; set; }
        public object customfield_28133 { get; set; }
        public object customfield_20219 { get; set; }
        public object customfield_20217 { get; set; }
        public object customfield_28136 { get; set; }
        public object customfield_20218 { get; set; }
        public object customfield_20215 { get; set; }
        public object customfield_20216 { get; set; }
        public object customfield_20213 { get; set; }
        public object customfield_20214 { get; set; }
        public string customfield_20211 { get; set; }
        public object customfield_20212 { get; set; }
        public string customfield_20210 { get; set; }
        public string customfield_31309 { get; set; }
        public object customfield_19221 { get; set; }
        public string customfield_31306 { get; set; }
        public string customfield_31305 { get; set; }
        public string customfield_31308 { get; set; }
        public string customfield_31307 { get; set; }
        public object customfield_11740 { get; set; }
        public object customfield_31302 { get; set; }
        public object customfield_31301 { get; set; }
        public object customfield_11742 { get; set; }
        public object customfield_31304 { get; set; }
        public object customfield_11741 { get; set; }
        public object customfield_31303 { get; set; }
        public object customfield_11735 { get; set; }
        public object customfield_31310 { get; set; }
        public object customfield_11737 { get; set; }
        public object customfield_11739 { get; set; }
        public object customfield_11738 { get; set; }
        public string customfield_20208 { get; set; }
        public string customfield_20209 { get; set; }
        public object customfield_20206 { get; set; }
        public string customfield_20207 { get; set; }
        public string customfield_20204 { get; set; }
        public object customfield_20205 { get; set; }
        public string customfield_20202 { get; set; }
        public string customfield_20203 { get; set; }
        public Customfield_20200 customfield_20200 { get; set; }
        public object customfield_19212 { get; set; }
        public string customfield_20201 { get; set; }
        public object customfield_19213 { get; set; }
        public object customfield_19214 { get; set; }
        public object customfield_19210 { get; set; }
        public object customfield_19219 { get; set; }
        public object customfield_31316 { get; set; }
        public object customfield_31319 { get; set; }
        public float customfield_31318 { get; set; }
        public object customfield_19215 { get; set; }
        public object customfield_31313 { get; set; }
        public object customfield_19216 { get; set; }
        public object customfield_19217 { get; set; }
        public object customfield_10400 { get; set; }
        public object customfield_19218 { get; set; }
        public object customfield_11722 { get; set; }
        public object customfield_31320 { get; set; }
        public object customfield_11721 { get; set; }
        public object customfield_29000 { get; set; }
        public object customfield_11724 { get; set; }
        public object customfield_31322 { get; set; }
        public object customfield_11723 { get; set; }
        public object customfield_31321 { get; set; }
        public object customfield_11726 { get; set; }
        public object customfield_11725 { get; set; }
        public object customfield_29004 { get; set; }
        public object customfield_11728 { get; set; }
        public string customfield_29001 { get; set; }
        public object customfield_11727 { get; set; }
        public string customfield_29002 { get; set; }
        public object customfield_29007 { get; set; }
        public object customfield_11729 { get; set; }
        public object customfield_29008 { get; set; }
        public string customfield_29006 { get; set; }
        public object customfield_21522 { get; set; }
        public object customfield_17821 { get; set; }
        public object customfield_17822 { get; set; }
        public object customfield_14306 { get; set; }
        public object customfield_14307 { get; set; }
        public object customfield_17815 { get; set; }
        public object customfield_26300 { get; set; }
        public object customfield_26302 { get; set; }
        public object customfield_26303 { get; set; }
        public object customfield_26308 { get; set; }
        public object customfield_26307 { get; set; }
        public object customfield_14300 { get; set; }
        public object customfield_14301 { get; set; }
        public object customfield_30801 { get; set; }
        public object customfield_14304 { get; set; }
        public object customfield_17814 { get; set; }
        public object customfield_14305 { get; set; }
        public object customfield_17813 { get; set; }
        public object customfield_14302 { get; set; }
        public object customfield_14303 { get; set; }
        public object customfield_17807 { get; set; }
        public object customfield_17806 { get; set; }
        public object customfield_17808 { get; set; }
        public object customfield_17803 { get; set; }
        public object customfield_17802 { get; set; }
        public object customfield_28502 { get; set; }
        public object customfield_28500 { get; set; }
        public object customfield_26328 { get; set; }
        public object customfield_28503 { get; set; }
        public object customfield_26327 { get; set; }
        public object customfield_26329 { get; set; }
        public object customfield_12103 { get; set; }
        public object customfield_26331 { get; set; }
        public object customfield_26330 { get; set; }
        public object customfield_26333 { get; set; }
        public object customfield_25001 { get; set; }
        public object customfield_26332 { get; set; }
        public object customfield_25002 { get; set; }
        public object customfield_26335 { get; set; }
        public object customfield_26334 { get; set; }
        public object customfield_26337 { get; set; }
        public object customfield_26339 { get; set; }
        public object customfield_26338 { get; set; }
        public object customfield_13418 { get; set; }
        public object customfield_26340 { get; set; }
        public object customfield_26342 { get; set; }
        public object customfield_26341 { get; set; }
        public object[] customfield_26344 { get; set; }
        public object customfield_26343 { get; set; }
        public object[] customfield_26346 { get; set; }
        public object[] customfield_26345 { get; set; }
        public Watches watches { get; set; }
        public Customfield_11226 customfield_11226 { get; set; }
        public object customfield_27200 { get; set; }
        public object customfield_27202 { get; set; }
        public object customfield_27201 { get; set; }
        public object customfield_27204 { get; set; }
        public object customfield_27203 { get; set; }
        public string customfield_27205 { get; set; }
        public object customfield_31709 { get; set; }
        public object customfield_31706 { get; set; }
        public object customfield_31705 { get; set; }
        public object customfield_31708 { get; set; }
        public object customfield_31707 { get; set; }
        public object timeoriginalestimate { get; set; }
        public object customfield_31702 { get; set; }
        public object customfield_31701 { get; set; }
        public object customfield_31704 { get; set; }
        public object customfield_31703 { get; set; }
        public object customfield_13403 { get; set; }
        public object customfield_31700 { get; set; }
        public object customfield_16904 { get; set; }
        public object customfield_21014 { get; set; }
        public object customfield_21013 { get; set; }
        public object customfield_21012 { get; set; }
        public object customfield_21011 { get; set; }
        public object customfield_31717 { get; set; }
        public object customfield_31716 { get; set; }
        public object customfield_31719 { get; set; }
        public object customfield_31718 { get; set; }
        public object customfield_31713 { get; set; }
        public object customfield_31712 { get; set; }
        public object customfield_31715 { get; set; }
        public object customfield_31714 { get; set; }
        public object customfield_31711 { get; set; }
        public object customfield_31710 { get; set; }
        public object customfield_29403 { get; set; }
        public object customfield_29401 { get; set; }
        public object customfield_29402 { get; set; }
        public object customfield_29407 { get; set; }
        public object customfield_21006 { get; set; }
        public object customfield_21005 { get; set; }
        public object customfield_29406 { get; set; }
        public object customfield_19604 { get; set; }
        public object customfield_19605 { get; set; }
        public object customfield_19606 { get; set; }
        public object[] fixVersions { get; set; }
        public object customfield_19607 { get; set; }
        public object customfield_19601 { get; set; }
        public object customfield_19602 { get; set; }
        public object customfield_19603 { get; set; }
        public object customfield_21913 { get; set; }
        public object customfield_26702 { get; set; }
        public object customfield_26701 { get; set; }
        public object customfield_26704 { get; set; }
        public object customfield_26703 { get; set; }
        public object customfield_26706 { get; set; }
        public object customfield_26705 { get; set; }
        public object customfield_17410 { get; set; }
        public object customfield_26708 { get; set; }
        public object customfield_26707 { get; set; }
        public object customfield_26709 { get; set; }
        public object customfield_17411 { get; set; }
        public object customfield_33005 { get; set; }
        public object customfield_21909 { get; set; }
        public object customfield_17409 { get; set; }
        public object customfield_33002 { get; set; }
        public object customfield_21908 { get; set; }
        public object customfield_17408 { get; set; }
        public object customfield_33003 { get; set; }
        public object customfield_21907 { get; set; }
        public object customfield_33000 { get; set; }
        public string customfield_21906 { get; set; }
        public object customfield_21905 { get; set; }
        public object customfield_21904 { get; set; }
        public object customfield_21903 { get; set; }
        public object customfield_21902 { get; set; }
        public object customfield_26710 { get; set; }
        public object customfield_26713 { get; set; }
        public object customfield_26712 { get; set; }
        public object customfield_26714 { get; set; }
        public object customfield_26717 { get; set; }
        public object customfield_18730 { get; set; }
        public object customfield_26716 { get; set; }
        public object customfield_26719 { get; set; }
        public object customfield_26718 { get; set; }
        public object customfield_17403 { get; set; }
        public object customfield_17402 { get; set; }
        public object customfield_17401 { get; set; }
        public object customfield_17407 { get; set; }
        public object customfield_33008 { get; set; }
        public object customfield_18732 { get; set; }
        public object customfield_17406 { get; set; }
        public object customfield_33009 { get; set; }
        public object customfield_17405 { get; set; }
        public object customfield_33006 { get; set; }
        public object customfield_17404 { get; set; }
        public object customfield_33007 { get; set; }
        public object customfield_33015 { get; set; }
        public object customfield_33016 { get; set; }
        public object customfield_33013 { get; set; }
        public object customfield_33014 { get; set; }
        public object customfield_18729 { get; set; }
        public object customfield_33012 { get; set; }
        public object customfield_33010 { get; set; }
        public object customfield_26720 { get; set; }
        public object customfield_28901 { get; set; }
        public object customfield_26722 { get; set; }
        public object customfield_28902 { get; set; }
        public object customfield_26721 { get; set; }
        public object customfield_26723 { get; set; }
        public object customfield_28905 { get; set; }
        public object customfield_28903 { get; set; }
        public object customfield_28904 { get; set; }
        public object customfield_33019 { get; set; }
        public object customfield_33017 { get; set; }
        public object customfield_33018 { get; set; }
        public object customfield_33020 { get; set; }
        public object customfield_33021 { get; set; }
        public Customfield_25401 customfield_25401 { get; set; }
        public object customfield_25402 { get; set; }
        public object customfield_25404 { get; set; }
        public object customfield_25405 { get; set; }
        public object customfield_25407 { get; set; }
        public object customfield_25408 { get; set; }
        public object customfield_25409 { get; set; }
        public object customfield_17860 { get; set; }
        public object customfield_18713 { get; set; }
        public object customfield_15203 { get; set; }
        public object customfield_15200 { get; set; }
        public object customfield_18715 { get; set; }
        public object customfield_15201 { get; set; }
        public object customfield_15207 { get; set; }
        public object customfield_15204 { get; set; }
        public object customfield_18711 { get; set; }
        public object customfield_18712 { get; set; }
        public object customfield_18706 { get; set; }
        public object customfield_18708 { get; set; }
        public string customfield_18709 { get; set; }
        public object customfield_25410 { get; set; }
        public object customfield_25411 { get; set; }
        public object customfield_25412 { get; set; }
        public object customfield_25413 { get; set; }
        public object customfield_25414 { get; set; }
        public object customfield_25415 { get; set; }
        public object customfield_25416 { get; set; }
        public object customfield_25417 { get; set; }
        public object customfield_25418 { get; set; }
        public object customfield_25419 { get; set; }
        public object customfield_17850 { get; set; }
        public object customfield_18702 { get; set; }
        public object customfield_18703 { get; set; }
        public object customfield_18704 { get; set; }
        public object customfield_18705 { get; set; }
        public object customfield_17856 { get; set; }
        public object customfield_18700 { get; set; }
        public object customfield_18701 { get; set; }
        public object customfield_17849 { get; set; }
        public object customfield_17848 { get; set; }
        public object customfield_25420 { get; set; }
        public object customfield_25421 { get; set; }
        public object[] customfield_27605 { get; set; }
        public object customfield_16512 { get; set; }
        public string customfield_16511 { get; set; }
        public object customfield_17841 { get; set; }
        public object customfield_17847 { get; set; }
        public string customfield_17845 { get; set; }
        public object customfield_24100 { get; set; }
        public object customfield_16501 { get; set; }
        public object customfield_16500 { get; set; }
        public string customfield_17830 { get; set; }
        public object customfield_16053 { get; set; }
        public object customfield_21400 { get; set; }
        public object customfield_24910 { get; set; }
        public object customfield_16052 { get; set; }
        public object customfield_24911 { get; set; }
        public object customfield_24912 { get; set; }
        public object customfield_16050 { get; set; }
        public object customfield_24913 { get; set; }
        public object customfield_16057 { get; set; }
        public object customfield_24915 { get; set; }
        public object customfield_24916 { get; set; }
        public object customfield_16054 { get; set; }
        public object customfield_24918 { get; set; }
        public object customfield_24919 { get; set; }
        public object customfield_29370 { get; set; }
        public object customfield_29373 { get; set; }
        public object customfield_29374 { get; set; }
        public object customfield_29371 { get; set; }
        public object customfield_29372 { get; set; }
        public object customfield_29377 { get; set; }
        public object customfield_29378 { get; set; }
        public object customfield_29375 { get; set; }
        public object customfield_29376 { get; set; }
        public object customfield_22727 { get; set; }
        public object customfield_29379 { get; set; }
        public object customfield_22725 { get; set; }
        public object customfield_22723 { get; set; }
        public object customfield_22722 { get; set; }
        public object customfield_22721 { get; set; }
        public object customfield_22720 { get; set; }
        public object customfield_16040 { get; set; }
        public object customfield_16046 { get; set; }
        public object customfield_16044 { get; set; }
        public object customfield_16049 { get; set; }
        public object customfield_16047 { get; set; }
        public object customfield_29380 { get; set; }
        public object customfield_29381 { get; set; }
        public object customfield_33400 { get; set; }
        public object customfield_33401 { get; set; }
        public object customfield_29382 { get; set; }
        public object customfield_22716 { get; set; }
        public object customfield_20536 { get; set; }
        public object customfield_22715 { get; set; }
        public object customfield_22713 { get; set; }
        public object customfield_20535 { get; set; }
        public object customfield_22712 { get; set; }
        public object customfield_20532 { get; set; }
        public object customfield_22711 { get; set; }
        public object customfield_22710 { get; set; }
        public object customfield_20530 { get; set; }
        public object customfield_20531 { get; set; }
        public Customfield_16030 customfield_16030 { get; set; }
        public object customfield_23604 { get; set; }
        public string customfield_16035 { get; set; }
        public object customfield_23605 { get; set; }
        public Customfield_16034 customfield_16034 { get; set; }
        public Customfield_16033 customfield_16033 { get; set; }
        public object customfield_23607 { get; set; }
        public object customfield_16039 { get; set; }
        public object customfield_16038 { get; set; }
        public object customfield_16037 { get; set; }
        public object customfield_16036 { get; set; }
        public object customfield_29392 { get; set; }
        public object customfield_20529 { get; set; }
        public object customfield_22708 { get; set; }
        public object customfield_10728 { get; set; }
        public object customfield_20527 { get; set; }
        public string customfield_22706 { get; set; }
        public object customfield_20528 { get; set; }
        public object customfield_20525 { get; set; }
        public object customfield_22704 { get; set; }
        public object customfield_20526 { get; set; }
        public object customfield_22703 { get; set; }
        public object customfield_20523 { get; set; }
        public object customfield_22702 { get; set; }
        public object customfield_20524 { get; set; }
        public object customfield_22701 { get; set; }
        public object customfield_20521 { get; set; }
        public object customfield_22700 { get; set; }
        public object customfield_20522 { get; set; }
        public object customfield_18200 { get; set; }
        public object customfield_20520 { get; set; }
        public object customfield_16024 { get; set; }
        public object customfield_16023 { get; set; }
        public object customfield_16022 { get; set; }
        public string customfield_16021 { get; set; }
        public object customfield_16026 { get; set; }
        public object customfield_16025 { get; set; }
        public object customfield_10714 { get; set; }
        public object customfield_20518 { get; set; }
        public object customfield_20519 { get; set; }
        public object customfield_20516 { get; set; }
        public object customfield_20517 { get; set; }
        public string customfield_20514 { get; set; }
        public Votes votes { get; set; }
        public string customfield_20515 { get; set; }
        public object customfield_20512 { get; set; }
        public string customfield_20513 { get; set; }
        public object customfield_20510 { get; set; }
        public string customfield_20511 { get; set; }
        public object customfield_25800 { get; set; }
        public object customfield_25801 { get; set; }
        public object customfield_16492 { get; set; }
        public object customfield_25802 { get; set; }
        public object customfield_16491 { get; set; }
        public string customfield_25803 { get; set; }
        public object customfield_16490 { get; set; }
        public object customfield_16010 { get; set; }
        public object customfield_16019 { get; set; }
        public object customfield_32101 { get; set; }
        public object customfield_10700 { get; set; }
        public object customfield_32102 { get; set; }
        public object customfield_20507 { get; set; }
        public object customfield_20505 { get; set; }
        public object customfield_20506 { get; set; }
        public object customfield_20503 { get; set; }
        public object customfield_20504 { get; set; }
        public object customfield_20501 { get; set; }
        public object customfield_20502 { get; set; }
        public object customfield_16002 { get; set; }
        public object customfield_16001 { get; set; }
        public object customfield_16000 { get; set; }
        public object customfield_16005 { get; set; }
        public object customfield_16489 { get; set; }
        public object customfield_32108 { get; set; }
        public object customfield_16004 { get; set; }
        public object customfield_16003 { get; set; }
        public object customfield_32105 { get; set; }
        public object customfield_16009 { get; set; }
        public object customfield_32104 { get; set; }
        public object customfield_16008 { get; set; }
        public object customfield_32107 { get; set; }
        public object customfield_16007 { get; set; }
        public object customfield_32106 { get; set; }
        public object customfield_16471 { get; set; }
        public object customfield_16470 { get; set; }
        public object customfield_16473 { get; set; }
        public object customfield_16472 { get; set; }
        public object customfield_24500 { get; set; }
        public object customfield_24501 { get; set; }
        public string customfield_24502 { get; set; }
        public object customfield_16464 { get; set; }
        public object customfield_16468 { get; set; }
        public Customfield_16469 customfield_16469 { get; set; }
        public object duedate { get; set; }
        public string customfield_21800 { get; set; }
        public object customfield_21002 { get; set; }
        public object customfield_21001 { get; set; }
        public object customfield_21000 { get; set; }
        public object customfield_31607 { get; set; }
        public object customfield_31606 { get; set; }
        public object customfield_31609 { get; set; }
        public object customfield_31608 { get; set; }
        public object customfield_31603 { get; set; }
        public object customfield_31605 { get; set; }
        public object customfield_31604 { get; set; }
        public object customfield_11201 { get; set; }
        public object customfield_31601 { get; set; }
        public object customfield_31600 { get; set; }
        public object customfield_27114 { get; set; }
        public object customfield_27113 { get; set; }
        public object customfield_27116 { get; set; }
        public object customfield_27118 { get; set; }
        public object customfield_27119 { get; set; }
        public object customfield_31618 { get; set; }
        public object customfield_31617 { get; set; }
        public object customfield_31619 { get; set; }
        public object customfield_31614 { get; set; }
        public object customfield_31613 { get; set; }
        public string customfield_31616 { get; set; }
        public object customfield_31615 { get; set; }
        public object customfield_31612 { get; set; }
        public object customfield_31611 { get; set; }
        public object customfield_27120 { get; set; }
        public string customfield_29304 { get; set; }
        public object customfield_29305 { get; set; }
        public string customfield_29302 { get; set; }
        public string customfield_29303 { get; set; }
        public object customfield_27129 { get; set; }
        public object customfield_27128 { get; set; }
        public string customfield_31625 { get; set; }
        public object customfield_31624 { get; set; }
        public object customfield_31621 { get; set; }
        public object customfield_31620 { get; set; }
        public object customfield_31623 { get; set; }
        public object customfield_31622 { get; set; }
        public object customfield_27130 { get; set; }
        public object customfield_12504 { get; set; }
        public object customfield_27132 { get; set; }
        public object aggregatetimeestimate { get; set; }
        public object customfield_27131 { get; set; }
        public object customfield_27134 { get; set; }
        public object customfield_29310 { get; set; }
        public object customfield_27133 { get; set; }
        public object customfield_29315 { get; set; }
        public object customfield_27136 { get; set; }
        public string customfield_27135 { get; set; }
        public object customfield_29313 { get; set; }
        public object customfield_29314 { get; set; }
        public object customfield_27137 { get; set; }
        public object customfield_22300 { get; set; }
        public Creator creator { get; set; }
        public object customfield_30300 { get; set; }
        public object customfield_30301 { get; set; }
        public object customfield_12500 { get; set; }
        public string customfield_29326 { get; set; }
        public object customfield_29324 { get; set; }
        public string customfield_29329 { get; set; }
        public object customfield_10310 { get; set; }
        public string customfield_10305 { get; set; }
        public object customfield_29333 { get; set; }
        public object customfield_10307 { get; set; }
        public object customfield_29334 { get; set; }
        public object customfield_29331 { get; set; }
        public object customfield_28000 { get; set; }
        public Customfield_10309 customfield_10309 { get; set; }
        public Customfield_29332 customfield_29332 { get; set; }
        public object customfield_28001 { get; set; }
        public object customfield_20109 { get; set; }
        public object customfield_29337 { get; set; }
        public object customfield_29338 { get; set; }
        public object customfield_20107 { get; set; }
        public object customfield_29335 { get; set; }
        public object customfield_20108 { get; set; }
        public object customfield_20105 { get; set; }
        public object customfield_20106 { get; set; }
        public object customfield_20103 { get; set; }
        public object customfield_29339 { get; set; }
        public string customfield_20104 { get; set; }
        public string customfield_20101 { get; set; }
        public string customfield_20102 { get; set; }
        public object customfield_20100 { get; set; }
        public object customfield_32509 { get; set; }
        public object customfield_32508 { get; set; }
        public object customfield_19110 { get; set; }
        public object customfield_32504 { get; set; }
        public object customfield_32501 { get; set; }
        public object customfield_32500 { get; set; }
        public object customfield_10300 { get; set; }
        public object customfield_32503 { get; set; }
        public string customfield_32502 { get; set; }
        public object customfield_29340 { get; set; }
        public object customfield_29341 { get; set; }
        public object customfield_32510 { get; set; }
        public object customfield_29344 { get; set; }
        public object customfield_29345 { get; set; }
        public object customfield_29342 { get; set; }
        public object customfield_29343 { get; set; }
        public object customfield_29348 { get; set; }
        public object customfield_29349 { get; set; }
        public object customfield_21428 { get; set; }
        public object customfield_29346 { get; set; }
        public object customfield_21427 { get; set; }
        public object customfield_29347 { get; set; }
        public Customfield_21424 customfield_21424 { get; set; }
        public object customfield_21423 { get; set; }
        public object customfield_19101 { get; set; }
        public object customfield_21422 { get; set; }
        public object customfield_21421 { get; set; }
        public object customfield_21420 { get; set; }
        public object customfield_19109 { get; set; }
        public object customfield_32512 { get; set; }
        public object customfield_32511 { get; set; }
        public object customfield_32514 { get; set; }
        public object customfield_32513 { get; set; }
        public object customfield_29351 { get; set; }
        public object customfield_29352 { get; set; }
        public object customfield_29350 { get; set; }
        public object customfield_29355 { get; set; }
        public object customfield_29353 { get; set; }
        public object customfield_29354 { get; set; }
        public object customfield_21419 { get; set; }
        public object customfield_29359 { get; set; }
        public object customfield_21418 { get; set; }
        public object customfield_21417 { get; set; }
        public object customfield_29357 { get; set; }
        public object customfield_21416 { get; set; }
        public object customfield_29358 { get; set; }
        public object customfield_21415 { get; set; }
        public object customfield_21414 { get; set; }
        public object customfield_21412 { get; set; }
        public object customfield_21411 { get; set; }
        public object customfield_21410 { get; set; }
        public object customfield_24900 { get; set; }
        public object customfield_24901 { get; set; }
        public object customfield_24904 { get; set; }
        public object customfield_24905 { get; set; }
        public object customfield_24906 { get; set; }
        public object customfield_24907 { get; set; }
        public object customfield_24908 { get; set; }
        public object customfield_24909 { get; set; }
        public object customfield_29362 { get; set; }
        public object customfield_29363 { get; set; }
        public object customfield_11603 { get; set; }
        public object customfield_29360 { get; set; }
        public object customfield_31201 { get; set; }
        public object customfield_11602 { get; set; }
        public object customfield_29366 { get; set; }
        public object customfield_29367 { get; set; }
        public object customfield_29364 { get; set; }
        public object customfield_21409 { get; set; }
        public object customfield_21408 { get; set; }
        public object customfield_21407 { get; set; }
        public object customfield_21406 { get; set; }
        public object customfield_21405 { get; set; }
        public object customfield_21404 { get; set; }
        public object customfield_21403 { get; set; }
        public object customfield_21402 { get; set; }
        public object customfield_21401 { get; set; }
        public object customfield_22299 { get; set; }
        public object customfield_22297 { get; set; }
        public object customfield_17700 { get; set; }
        public object customfield_22294 { get; set; }
        public object customfield_22293 { get; set; }
        public object customfield_22292 { get; set; }
        public object customfield_22291 { get; set; }
        public object customfield_17704 { get; set; }
        public object customfield_22290 { get; set; }
        public string customfield_17702 { get; set; }
        public object customfield_17701 { get; set; }
        public object customfield_24000 { get; set; }
        public object customfield_24001 { get; set; }
        public object customfield_24002 { get; set; }
        public object customfield_24003 { get; set; }
        public object customfield_24004 { get; set; }
        public object customfield_24005 { get; set; }
        public object customfield_24006 { get; set; }
        public object customfield_22289 { get; set; }
        public object customfield_22288 { get; set; }
        public object customfield_22286 { get; set; }
        public object customfield_22285 { get; set; }
        public string customfield_13331 { get; set; }
        public object customfield_22283 { get; set; }
        public string customfield_13330 { get; set; }
        public object customfield_22282 { get; set; }
        public object customfield_22281 { get; set; }
        public string customfield_13332 { get; set; }
        public object customfield_22280 { get; set; }
        public string customfield_13328 { get; set; }
        public string customfield_13327 { get; set; }
        public string customfield_13329 { get; set; }
        public Customfield_29700[] customfield_29700 { get; set; }
        public object customfield_29701 { get; set; }
        public object customfield_29702 { get; set; }
        public object customfield_29703 { get; set; }
        public object customfield_29708 { get; set; }
        public object customfield_22279 { get; set; }
        public object customfield_29709 { get; set; }
        public object customfield_22278 { get; set; }
        public object customfield_29706 { get; set; }
        public object customfield_22277 { get; set; }
        public object customfield_29707 { get; set; }
        public string customfield_22276 { get; set; }
        public object customfield_22275 { get; set; }
        public string customfield_13320 { get; set; }
        public string customfield_15500 { get; set; }
        public string customfield_22271 { get; set; }
        public string customfield_22270 { get; set; }
        public string customfield_13321 { get; set; }
        public string customfield_13324 { get; set; }
        public object customfield_13323 { get; set; }
        public string customfield_13326 { get; set; }
        public string customfield_13325 { get; set; }
        public string customfield_13317 { get; set; }
        public Customfield_13316[] customfield_13316 { get; set; }
        public string customfield_13319 { get; set; }
        public string customfield_13318 { get; set; }
        public object customfield_26201 { get; set; }
        public object customfield_29711 { get; set; }
        public object customfield_26200 { get; set; }
        public object customfield_29712 { get; set; }
        public object customfield_29710 { get; set; }
        public object customfield_26205 { get; set; }
        public object customfield_26204 { get; set; }
        public object customfield_26207 { get; set; }
        public object customfield_26206 { get; set; }
        public object customfield_22269 { get; set; }
        public object customfield_26209 { get; set; }
        public object customfield_30708 { get; set; }
        public object customfield_22268 { get; set; }
        public object customfield_22267 { get; set; }
        public string customfield_22266 { get; set; }
        public string customfield_22265 { get; set; }
        public object customfield_30704 { get; set; }
        public object customfield_22264 { get; set; }
        public object customfield_30705 { get; set; }
        public object customfield_22263 { get; set; }
        public object customfield_30706 { get; set; }
        public object customfield_22262 { get; set; }
        public object customfield_30707 { get; set; }
        public object customfield_22261 { get; set; }
        public object customfield_30700 { get; set; }
        public object customfield_30701 { get; set; }
        public Customfield_13311 customfield_13311 { get; set; }
        public object customfield_30702 { get; set; }
        public Customfield_13310 customfield_13310 { get; set; }
        public object customfield_30703 { get; set; }
        public Customfield_13313 customfield_13313 { get; set; }
        public string customfield_13312 { get; set; }
        public string customfield_13315 { get; set; }
        public string customfield_13314 { get; set; }
        public string customfield_13306 { get; set; }
        public object customfield_13308 { get; set; }
        public Customfield_13307 customfield_13307 { get; set; }
        public Customfield_13309 customfield_13309 { get; set; }
        public object customfield_26210 { get; set; }
        public object customfield_26212 { get; set; }
        public object customfield_26211 { get; set; }
        public object customfield_26213 { get; set; }
        public object customfield_26216 { get; set; }
        public object customfield_26215 { get; set; }
        public object customfield_22259 { get; set; }
        public object customfield_26217 { get; set; }
        public object customfield_22258 { get; set; }
        public object customfield_22257 { get; set; }
        public object customfield_26219 { get; set; }
        public object customfield_22254 { get; set; }
        public object[] customfield_23101 { get; set; }
        public object customfield_22253 { get; set; }
        public object customfield_22252 { get; set; }
        public object customfield_22251 { get; set; }
        public object customfield_22250 { get; set; }
        public object customfield_26221 { get; set; }
        public DateTime? resolutiondate { get; set; }
        public object customfield_26220 { get; set; }
        public object customfield_26223 { get; set; }
        public object[] customfield_28402 { get; set; }
        public object customfield_26222 { get; set; }
        public object customfield_28403 { get; set; }
        public object customfield_28400 { get; set; }
        public object customfield_26224 { get; set; }
        public object customfield_26226 { get; set; }
        public object customfield_22249 { get; set; }
        public object customfield_26229 { get; set; }
        public object customfield_28404 { get; set; }
        public object customfield_22248 { get; set; }
        public object customfield_32909 { get; set; }
        public object customfield_32908 { get; set; }
        public object customfield_32904 { get; set; }
        public object customfield_22241 { get; set; }
        public object customfield_32907 { get; set; }
        public object customfield_22240 { get; set; }
        public object customfield_32906 { get; set; }
        public object customfield_32901 { get; set; }
        public object customfield_12446 { get; set; }
        public object customfield_26231 { get; set; }
        public object customfield_26234 { get; set; }
        public object customfield_26233 { get; set; }
        public object customfield_22239 { get; set; }
        public object customfield_32919 { get; set; }
        public string customfield_32916 { get; set; }
        public string customfield_32915 { get; set; }
        public object customfield_32918 { get; set; }
        public object customfield_32917 { get; set; }
        public object customfield_32912 { get; set; }
        public object customfield_32911 { get; set; }
        public object customfield_32914 { get; set; }
        public object customfield_32913 { get; set; }
        public object customfield_12435 { get; set; }
        public object customfield_14610 { get; set; }
        public object customfield_32910 { get; set; }
        public object customfield_12434 { get; set; }
        public object customfield_14605 { get; set; }
        public object customfield_14606 { get; set; }
        public object customfield_14603 { get; set; }
        public object customfield_14604 { get; set; }
        public string customfield_14609 { get; set; }
        public object customfield_14607 { get; set; }
        public object customfield_14608 { get; set; }
        public object customfield_22228 { get; set; }
        public object customfield_22226 { get; set; }
        public object customfield_32921 { get; set; }
        public object customfield_32920 { get; set; }
        public object customfield_15925 { get; set; }
        public object customfield_15924 { get; set; }
        public object customfield_27101 { get; set; }
        public Customfield_27100 customfield_27100 { get; set; }
        public object customfield_27102 { get; set; }
        public object customfield_22217 { get; set; }
        public object customfield_22216 { get; set; }
        public object customfield_27109 { get; set; }
        public object customfield_22215 { get; set; }
        public object customfield_25724 { get; set; }
        public object customfield_27903 { get; set; }
        public object customfield_27902 { get; set; }
        public object customfield_27905 { get; set; }
        public object customfield_27904 { get; set; }
        public object customfield_15121 { get; set; }
        public object customfield_27907 { get; set; }
        public object customfield_15122 { get; set; }
        public object customfield_27906 { get; set; }
        public object customfield_15120 { get; set; }
        public object customfield_15125 { get; set; }
        public object customfield_15123 { get; set; }
        public object customfield_15124 { get; set; }
        public object customfield_32017 { get; set; }
        public string customfield_32016 { get; set; }
        public object customfield_32019 { get; set; }
        public object customfield_32018 { get; set; }
        public string customfield_32024 { get; set; }
        public object customfield_32023 { get; set; }
        public object customfield_32026 { get; set; }
        public object customfield_32025 { get; set; }
        public object customfield_32020 { get; set; }
        public object customfield_32022 { get; set; }
        public object customfield_24400 { get; set; }
        public object customfield_25732 { get; set; }
        public object customfield_25735 { get; set; }
        public object customfield_15110 { get; set; }
        public object customfield_15111 { get; set; }
        public object customfield_15114 { get; set; }
        public object customfield_15115 { get; set; }
        public Customfield_15112 customfield_15112 { get; set; }
        public object customfield_15113 { get; set; }
        public object customfield_15118 { get; set; }
        public object customfield_15119 { get; set; }
        public object customfield_15116 { get; set; }
        public object customfield_15117 { get; set; }
        public object customfield_15109 { get; set; }
        public object customfield_20930 { get; set; }
        public object customfield_20931 { get; set; }
        public string customfield_15100 { get; set; }
        public object customfield_15103 { get; set; }
        public object customfield_15101 { get; set; }
        public object customfield_15102 { get; set; }
        public object customfield_15107 { get; set; }
        public object customfield_15108 { get; set; }
        public object customfield_15105 { get; set; }
        public object customfield_15106 { get; set; }
        public object customfield_20929 { get; set; }
        public string customfield_16429 { get; set; }
        public object customfield_20928 { get; set; }
        public object customfield_20925 { get; set; }
        public object customfield_20926 { get; set; }
        public object customfield_20923 { get; set; }
        public object customfield_20924 { get; set; }
        public object customfield_20921 { get; set; }
        public object customfield_20920 { get; set; }
        public object customfield_16420 { get; set; }
        public object customfield_16422 { get; set; }
        public Aggregateprogress aggregateprogress { get; set; }
        public object customfield_16428 { get; set; }
        public object customfield_16427 { get; set; }
        public object customfield_16419 { get; set; }
        public object customfield_16418 { get; set; }
        public object customfield_20919 { get; set; }
        public object customfield_20916 { get; set; }
        public object customfield_20917 { get; set; }
        public object customfield_20915 { get; set; }
        public object customfield_16411 { get; set; }
        public object customfield_16410 { get; set; }
        public object customfield_16417 { get; set; }
        public object customfield_19920 { get; set; }
        public Customfield_16415 customfield_16415 { get; set; }
        public object customfield_16414 { get; set; }
        public object customfield_16409 { get; set; }
        public object customfield_16408 { get; set; }
        public object customfield_20907 { get; set; }
        public object customfield_16407 { get; set; }
        public string customfield_20908 { get; set; }
        public object customfield_20905 { get; set; }
        public object customfield_19916 { get; set; }
        public object customfield_19917 { get; set; }
        public object customfield_19919 { get; set; }
        public object customfield_20901 { get; set; }
        public object customfield_28801 { get; set; }
        public object customfield_16402 { get; set; }
        public object customfield_19912 { get; set; }
        public object customfield_16401 { get; set; }
        public object customfield_19913 { get; set; }
        public object customfield_19914 { get; set; }
        public object customfield_16400 { get; set; }
        public object customfield_19915 { get; set; }
        public string customfield_16406 { get; set; }
        public object customfield_19910 { get; set; }
        public object customfield_19911 { get; set; }
        public object customfield_19909 { get; set; }
        public object customfield_19905 { get; set; }
        public object customfield_19906 { get; set; }
        public object customfield_19907 { get; set; }
        public object customfield_19908 { get; set; }
        public object customfield_25300 { get; set; }
        public object customfield_25301 { get; set; }
        public object customfield_28813 { get; set; }
        public object customfield_28814 { get; set; }
        public string customfield_28812 { get; set; }
        public object customfield_28817 { get; set; }
        public object customfield_28818 { get; set; }
        public object customfield_28815 { get; set; }
        public object customfield_28816 { get; set; }
        public object customfield_28819 { get; set; }
        public object customfield_19901 { get; set; }
        public object customfield_19902 { get; set; }
        public object customfield_19903 { get; set; }
        public string customfield_19904 { get; set; }
        public object customfield_14201 { get; set; }
        public object customfield_17705 { get; set; }
    }

    public class Rootobject1
    {
        public Object _object { get; set; }
    }

    public class Object1
    {
        public string url { get; set; }
        public string title { get; set; }
        public Icon icon { get; set; }
        public Status status { get; set; }
    }

    public class Icon
    {
    }

    public class Status_1
    {
        public Icon1 icon { get; set; }
    }

    public class Icon1
    {
    }
    public class Customfield_20426
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_20421
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_19403
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_29212
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_29213
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_29211
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_22640
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_21308
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_13203
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Reporter
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public Avatarurls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }

    public class Avatarurls
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_15837
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_12312
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_12313
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_15006
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_20827
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_20822
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_20804
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_24304
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_20305
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Assignee
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public Avatarurls1 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }

    public class Avatarurls1
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_19303
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_31009
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Status
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public Statuscategory statusCategory { get; set; }
    }

    public class Statuscategory
    {
        public string self { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public string colorName { get; set; }
        public string name { get; set; }
    }

    public class Customfield_26417
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26419
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_15759
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_15757
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_15755
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Progress
    {
        public int progress { get; set; }
        public int total { get; set; }
    }

    public class Project
    {
        public string self { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public Avatarurls2 avatarUrls { get; set; }
    }

    public class Avatarurls2
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_10002
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26400
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26402
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26405
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26408
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_15775
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26411
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26413
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26415
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Resolution
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
    }

    public class Issuetype
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public bool subtask { get; set; }
        public int avatarId { get; set; }
    }

    public class Customfield_18311
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26807
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_14805
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_14806
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_22408
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_20200
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Watches
    {
        public string self { get; set; }
        public int watchCount { get; set; }
        public bool isWatching { get; set; }
    }

    public class Customfield_11226
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_25401
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_16030
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_16034
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_16033
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Votes
    {
        public string self { get; set; }
        public int votes { get; set; }
        public bool hasVoted { get; set; }
    }

    public class Customfield_16469
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Creator
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public Avatarurls3 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }

    public class Avatarurls3
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_10309
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_29332
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_21424
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_13311
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public Avatarurls4 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }

    public class Avatarurls4
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_13310
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public Avatarurls5 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }

    public class Avatarurls5
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_13313
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_13307
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_13309
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_27100
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_15112
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Aggregateprogress
    {
        public int progress { get; set; }
        public int total { get; set; }
    }

    public class Customfield_16415
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Issuelink
    {
        public string id { get; set; }
        public string self { get; set; }
        public Type type { get; set; }
        public Inwardissue inwardIssue { get; set; }
        public Outwardissue outwardIssue { get; set; }
    }

    public class Type
    {
        public string id { get; set; }
        public string name { get; set; }
        public string inward { get; set; }
        public string outward { get; set; }
        public string self { get; set; }
    }

    public class Inwardissue
    {
        public string id { get; set; }
        public string key { get; set; }
        public string self { get; set; }
        public Fields1 fields { get; set; }
    }

    public class Fields1
    {
        public string summary { get; set; }
        public Status1 status { get; set; }
        public Priority priority { get; set; }
        public Issuetype1 issuetype { get; set; }
    }

    public class Status1
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public Statuscategory1 statusCategory { get; set; }
    }

    public class Statuscategory1
    {
        public string self { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public string colorName { get; set; }
        public string name { get; set; }
    }

    public class Priority
    {
        public string self { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Issuetype1
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public bool subtask { get; set; }
        public int avatarId { get; set; }
    }

    public class Outwardissue
    {
        public string id { get; set; }
        public string key { get; set; }
        public string self { get; set; }
        public Fields2 fields { get; set; }
    }

    public class Fields2
    {
        public string summary { get; set; }
        public Status2 status { get; set; }
        public Priority1 priority { get; set; }
        public Issuetype2 issuetype { get; set; }
    }

    public class Status2
    {
        public string self { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public Statuscategory2 statusCategory { get; set; }
    }

    public class Statuscategory2
    {
        public string self { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public string colorName { get; set; }
        public string name { get; set; }
    }

    public class Priority1
    {
        public string self { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Issuetype2
    {
        public string self { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }
        public string name { get; set; }
        public bool subtask { get; set; }
        public int avatarId { get; set; }
    }

    public class Customfield_21313
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26805
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_26806
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_19250
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_22411
    {
        public string self { get; set; }
        public string name { get; set; }
        public string key { get; set; }
        public string emailAddress { get; set; }
        public Avatarurls6 avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string timeZone { get; set; }
    }

    public class Avatarurls6
    {
        public string _48x48 { get; set; }
        public string _24x24 { get; set; }
        public string _16x16 { get; set; }
        public string _32x32 { get; set; }
    }

    public class Customfield_29700
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }

    public class Customfield_13316
    {
        public string self { get; set; }
        public string value { get; set; }
        public string id { get; set; }
    }
}