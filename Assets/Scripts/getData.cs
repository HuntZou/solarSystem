using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;

public class getData : MonoBehaviour {
	private Socket client;
	private int count = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (++count);
		TcpClient client = new TcpClient ();
		client.Connect (IPAddress.Parse("127.0.0.1"),1995);
		NetworkStream stream = client.GetStream ();
		byte[] info = System.Text.Encoding.Default.GetBytes ("bingo:"+Time.deltaTime);
		stream.Write (info,0,info.Length);
		client.Close ();
	}
}
