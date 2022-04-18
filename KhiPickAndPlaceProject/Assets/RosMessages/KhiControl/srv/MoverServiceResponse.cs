//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.KhiControl
{
    [Serializable]
    public class MoverServiceResponse : Message
    {
        public const string k_RosMessageName = "khi_control/MoverService";
        public override string RosMessageName => k_RosMessageName;

        public Moveit.RobotTrajectoryMsg[] trajectories;

        public MoverServiceResponse()
        {
            this.trajectories = new Moveit.RobotTrajectoryMsg[0];
        }

        public MoverServiceResponse(Moveit.RobotTrajectoryMsg[] trajectories)
        {
            this.trajectories = trajectories;
        }

        public static MoverServiceResponse Deserialize(MessageDeserializer deserializer) => new MoverServiceResponse(deserializer);

        private MoverServiceResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.trajectories, Moveit.RobotTrajectoryMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.trajectories);
            serializer.Write(this.trajectories);
        }

        public override string ToString()
        {
            return "MoverServiceResponse: " +
            "\ntrajectories: " + System.String.Join(", ", trajectories.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}
