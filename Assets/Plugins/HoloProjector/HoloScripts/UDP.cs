using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading;
using System;

public class UDP : MonoBehaviour
{

    UdpClient udpClient;
    IPEndPoint targetPoint;




    bool udp_send_flag = false;
    bool udp_recv_flag = false;
    public void Start_UDPSender(int self_port, int target_port)
    {
        if (udp_send_flag == true)
            return;
        udpClient = new UdpClient(self_port);

        targetPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), target_port);

        udp_send_flag = true;
    }
    Thread thrRecv;
    private UdpClient UDPrecv;
    private IPEndPoint endpoint;
    private byte[] recvBuf;
    private Thread recvThread;
    public void Start_UDPReceive(int recv_port)
    {
        if (udp_recv_flag == true)
            return;

        UDPrecv = new UdpClient(new IPEndPoint(IPAddress.Any, recv_port));
        endpoint = new IPEndPoint(IPAddress.Any, 0);
        recvThread = new Thread(new ThreadStart(RecvThread));
        recvThread.IsBackground = true;
        recvThread.Start();

        udp_recv_flag = true;


    }


    public void Close_UDPSender()
    {
        // if (udp_send_flag == false)
        //     return;
        udpClient.Close();
        recvThread.Interrupt();
        recvThread.Abort();
        udp_send_flag = false;
    }

    public void Close_UDPReceive()
    {
        if (udp_recv_flag == false)
            return;
        //udpClient.Close();
        recvThread.Interrupt();
        recvThread.Abort();
        udp_recv_flag = false;
    }

    public void Write_UDPSender(string strdata)
    {
        if (udp_send_flag == false)
            return;
        byte[] sendData = Encoding.Default.GetBytes(strdata);
        udpClient.Send(sendData, sendData.Length, targetPoint);
    }

    

    public string Read_UDPReceive()
    {
        returnstr = String.Copy(recvdata);
        if (old)
        {
            old = false;
            recvdata = "";
            return returnstr;
        }
        else
            return "";
    }

    bool old = false;
    string returnstr;
    string recvdata;
    private bool messageReceive;
    private void ReceiveCallback(IAsyncResult ar)
    {
        recvBuf = UDPrecv.EndReceive(ar, ref endpoint);
        recvdata = Encoding.Default.GetString(recvBuf);
        old = true;
        messageReceive = true;
    }
    private void RecvThread()
    {

        messageReceive = true;

        while (true)
        {
            if (isover == 1)//结束线程 没这句话会死机
                return;
            try
            {
                if (messageReceive)
                {
                    UDPrecv.BeginReceive(new AsyncCallback(ReceiveCallback), null);
                    messageReceive = false;
                }
            }
            catch (Exception e)
            {

            }
        }
    }







    // Start is called before the first frame update
    void Start()
    {
        //Start_TCPClient("192.168.199.231",2333);
        //Start_UDPSender(7777,6666);
        ListenThread listener = new ListenThread();  
        Thread listenThread = new Thread(new ThreadStart(listener.run));  
        listenThread.Start();  
        listener.stop();


        Start_UDPReceive(2333);
    }


    string UDPGet;
    // Update is called once per frame
    public static float cam_x = 1.4f, cam_y = 0f, cam_z = 0f, QuaternionX, QuaternionY, QuaternionZ, QuaternionW;
    void Update()
    {
        UDPGet = Read_UDPReceive();
        //print(UDPGet);
        if (UDPGet != "")
        {
            print("UDPOK");
            //print(aaa.Split(',')[2]);
            var receive = UDPGet.Split(',');
            //print(UDPGet);
            cam_x = float.Parse(receive[0]);
            cam_y = float.Parse(receive[1]);
            cam_z = float.Parse(receive[2]);

            QuaternionX = float.Parse(receive[3]);
            QuaternionY = float.Parse(receive[4]);
            QuaternionZ = float.Parse(receive[5]);
            QuaternionW = float.Parse(receive[6]);
            //print (cam_z);
            //print(cam_x);
        }

    }

    void OnApplicationQuit()
    {
        Close_UDPReceive();
        isover = 1;
        recvThread.Interrupt();
        recvThread.Abort();
        //print("Destroy!");
    }

    private void OnDestroy()
    {
        Close_UDPReceive();
        isover = 1;
        recvThread.Abort();
        recvThread.Interrupt();
        //print("Destroy2!");
        
    }

    int isover = 0;

    public class ListenThread  
{  
   public void run()  
   {  
      Console.Write("creating listen socket ...");  
      listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);  
      listenSocket.Bind(new IPEndPoint(IPAddress.Any, 65365));  
      listenSocket.Listen(0);  
      Console.Write("    done.\n");  
  
      try  
      {  
         Console.Write("listening ...");  
         ioSocket = listenSocket.Accept();  
         Console.Write("    accepted.\n");  
  
         Console.Write("creating I/O thread ...");  
         // new Thread(new ThreadStart(this.networkIOThreadProc)).Start();  
         Console.Write("    done.\n");  
      }  
      catch (Exception e)  
      {  
         Console.WriteLine("Thread aborted.");  
      }  
      finally  
      {  
         Console.WriteLine("Thread resource released.");  
      }  
   }  
  
   public void stop()  
   {  
      if (listenSocket != null)  
      {  
         listenSocket.Close();  
      }  
   }  
  
   private Socket listenSocket = null;  
   private Socket ioSocket = null;  
  
}  


}

