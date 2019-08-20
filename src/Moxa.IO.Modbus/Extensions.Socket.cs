using System.Net.Sockets;

namespace Moxa
{
    public static partial class Extensions
    {
        /// <summary>
        /// Determines whether [is socket connected].
        /// </summary>
        /// <param name="socket">The socket.</param>
        /// <returns>
        ///   <c>true</c> if [is socket connected] [the specified socket]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsConnected(this Socket socket)
        {
            #region remarks
            /*
             * Depending on http://msdn.microsoft.com/zh-cn/library/system.net.sockets.socket.connected.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-2
             */
            #endregion

            // This is how you can determine whether a socket is still connected.
            bool state = true;
            bool blocking = socket.Blocking;
            try
            {
                byte[] tmp = new byte[1];
                socket.Blocking = false;
                socket.Send(tmp, 0, 0);
                state = true;
            }
            catch (SocketException e)
            {
                if (e.NativeErrorCode.Equals((int)SocketError.WouldBlock)) state = true;
                else state = false;
            }
            finally
            {
                socket.Blocking = blocking;
            }

            return state;
        }

        /// <summary>
        /// Determines whether [is socket connected] [the specified interval].
        /// </summary>
        /// <param name="socket">The socket.</param>
        /// <param name="interval">The interval.</param>
        /// <returns>
        ///   <c>true</c> if [is socket connected] [the specified interval]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsConnected(this Socket socket, int interval = 1000)
        {
            #region remarks
            /* As zendar wrote, it is nice to use the Socket.Poll and Socket.Available, but you need to take into consideration 
             * that the socket might not have been initialized in the first place. 
             * This is the last (I believe) piece of information and it is supplied by the Socket.Connected property. 
             * The revised version of the method would looks something like this: 
             * from：http://stackoverflow.com/questions/2661764/how-to-check-if-a-socket-is-connected-disconnected-in-c */
            #endregion

            /* The long, but simpler-to-understand version:

                    bool part1 = s.Poll(1000, SelectMode.SelectRead);
                    bool part2 = (s.Available == 0);
                    if ((part1 && part2 ) || !s.Connected)
                        return false;
                    else
                        return true;

            */

            return socket == null ? false : !((socket.Poll(interval, SelectMode.SelectRead) && (socket.Available == 0)) || !socket.Connected);
        }
    }
}