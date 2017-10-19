using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    /// <summary>
    ///
    /// </summary>
    public class ObjectFormatUtil
    {
        /// <summary>
        /// session
        /// </summary>
        public static string SessionName = "SessionLoginMsgOKU_House";

        /// <summary>
        /// cookie
        /// </summary>
        public static string CookieName = "CookieLoginMsgOKU_House";

        /// <summary>
        /// 获取时间流水号
        /// </summary>
        /// <param name="index">
        /// 时间格式：
        /// 0：年月日时分秒毫秒
        /// 1：年月日时分秒
        /// 2：年月日
        /// 3：时分秒
        /// 4: 年月
        /// </param>
        /// <returns></returns>
        public static string GetNumByDateTime(int index){
            string resultNum = "";
            DateTime dt = DateTime.Now;
            switch (index) { 
                case 0:
                    resultNum = dt.ToString("yyyyMMddHHmmssfff");
                    break;
                case 1:
                    resultNum = dt.ToString("yyyyMMddHHmmss");
                    break;
                case 2:
                    resultNum = dt.ToString("yyyyMMdd");
                    break;
                case 3:
                    resultNum = dt.ToString("HHmmss");
                    break;
                case 4:
                    resultNum = dt.ToString("yyyyMM");
                    break;
            }
            
            return resultNum;
        }

        /// <summary>
        /// 获取GUID流水号保留‘-‘
        /// </summary>
        /// <param name="flg">true 大写 false 小写</param>
        /// <returns></returns>
        public static string GetNumByGUID(bool flg)
        {
            string resultNum = "";
            resultNum = Guid.NewGuid().ToString();
            if (flg)
            {
                resultNum = resultNum.ToUpper();
            }
            return resultNum;
        }

        /// <summary>
        /// 获取GUID流水号去掉‘-‘
        /// </summary>
        /// <param name="flg">true 大写 false 小写</param>
        /// <returns></returns>
        public static string GetNumByGUIDAwayLine(bool flg)
        {
            string resultNum = "";
            resultNum = Guid.NewGuid().ToString().Replace("-","");
            if (flg)
            {
                resultNum = resultNum.ToUpper();
            }
            return resultNum;
        }

    }


}
