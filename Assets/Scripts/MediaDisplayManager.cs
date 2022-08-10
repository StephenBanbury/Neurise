using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Assets.Scripts
{
    public class MediaDisplayManager : MonoBehaviour
    {
        public static MediaDisplayManager instance;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // TODO: remove - not required
        public void CreateStreamSelectButtons()
        {
        }


        private bool AssignStreamToDisplay(int streamId, int displayId)
        {
            Debug.Log($"Assign video stream {streamId} to display {displayId}");

            //try
            //{
            if (streamId > 0 && displayId > 0)
            {
                var agoraUsers = AgoraController.instance.AgoraUsers;

                if (agoraUsers.Any())
                {
                    Debug.Log("agoraUsers: -");
                    foreach (var user in agoraUsers)
                    {
                        Debug.Log(
                            $" - {user.Uid} (isLocal: {user.IsLocal}, leftRoom: {user.LeftRoom}, id: {user.Id})");
                    }

                    var agoraUser = agoraUsers.FirstOrDefault(u => u.Id == streamId);

                    Debug.Log($"agoraUser exists: {agoraUser != null}");

                    if (agoraUser != null)
                    {
                        if (agoraUser.IsLocal || agoraUser.LeftRoom)
                        {
                            Debug.Log(
                                $"Something has gone wrong - is local: {agoraUser.IsLocal}, left room: {agoraUser.LeftRoom}.");
                        }
                        else
                        {
                            agoraUser.DisplayId = displayId;
                            AgoraController.instance.AssignStreamToDisplay(agoraUser);
                        }
                    }
                }

                return true;
            }

            return false;
            //}
            //catch (Exception exception)
            //{
            //    Debug.Log(exception);
            //    return false;
            //}
        }

    }
}