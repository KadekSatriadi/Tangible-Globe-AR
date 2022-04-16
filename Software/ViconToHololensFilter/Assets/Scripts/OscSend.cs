//This takes the object tracked by the Vicon, using the RB script, and spits out a simplified osc message with just position vector and rotation quaternion.  Duplicate osc managers and these objects to address multiple devices

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class OscSend : MonoBehaviour
{
    public GameObject OSCManager;
    OSCTransmitter transmitter;
    Vector3 lastPostion = new Vector3();
    Quaternion lastRotation = new Quaternion();
    public string OscAddress = "/test"; // Call this your vicon object
    public Transform theObject;
    public float xOffset;
    public float yOffset;
    public float zOffset;
    long count;
    // Start is called before the first frame update
    void Start()
    {
        transmitter = OSCManager.GetComponent<OSCTransmitter>();
    }


    void Update()
    {
        count++;
       // if (count % 10 == 0)
        //{
            if (theObject.position != lastPostion || theObject.rotation != lastRotation)
            {
                var message = new OSCMessage(OscAddress);
                message.AddValue(OSCValue.Float(theObject.position.x + xOffset));
                message.AddValue(OSCValue.Float(theObject.position.y + yOffset));
                message.AddValue(OSCValue.Float(theObject.position.z + zOffset));
                message.AddValue(OSCValue.Float(theObject.rotation.x));
                message.AddValue(OSCValue.Float(theObject.rotation.y));
                message.AddValue(OSCValue.Float(theObject.rotation.z));
                message.AddValue(OSCValue.Float(theObject.rotation.w));
                transmitter.Send(message);
                lastPostion = theObject.position;
                lastRotation = theObject.rotation;


            }
        //}
    }

}

