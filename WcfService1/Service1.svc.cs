using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{

    public interface IService1 { }


    /// <summary>
    /// 假的，只是为了VS编译通过。真正实现见 Service1.svc 。
    /// </summary>
    public class FakeService1 : IService1
    {
        
    }
}
