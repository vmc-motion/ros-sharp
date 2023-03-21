/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Header : Message
    {
        public const string RosMessageName = "std_msgs/Header";

        //  Standard metadata for higher-level stamped data types.
        //  This is generally used to communicate timestamped data 
        //  in a particular coordinate frame.
        //  
        //  sequence ID: consecutively increasing ID 
        //public uint seq { get; set; }
        // Two-integer timestamp that is expressed as:
        //  * stamp.sec: seconds (stamp_secs) since epoch (in Python the variable is called 'secs')
        //  * stamp.nsec: nanoseconds since stamp_secs (in Python the variable is called 'nsecs')
        //  time-handling sugar is provided by the client library
        public Time stamp { get; set; }
        // Frame this data is associated with
        //  0: no frame
        //  1: global frame
        public string frame_id { get; set; }

        public Header()
        {
            //this.seq = 0;
            this.stamp = new Time();
            this.frame_id = "";
        }

        public Header(uint seq, Time stamp, string frame_id)
        {
            //this.seq = seq;
            this.stamp = stamp;
            this.frame_id = frame_id;
        }
    }
}
