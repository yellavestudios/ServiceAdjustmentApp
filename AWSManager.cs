using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Runtime;
using System.IO;
using System;
using Amazon.S3.Util;
using System.Collections.Generic;
using Amazon.CognitoIdentity;
using Amazon;

public class AWSManager : MonoBehaviour
{

    public string S3Region = RegionEndpoint.USEast1.SystemName;
    //property from AWS
    private RegionEndpoint _S3Region;
    {
        get { return RegionEndpoint.GetBySystemName(S3Region); 
    }

    

    private void Awake()
    {

        UnityInitializer.AttachToGameObject(this.gameObject);
        //Use Unity Web Request
        AWSConfigs.HttpClient = AWSConfigs.HttpClientOption.UnityWebRequest;

    //initialize credentials with AWS
    CognitoAWSCredentials credentials = new CognitoAWSCredentials(
        "us-east-1:6afff219-0978-43dc-9314-70dd4f14292f", // Identity Pool ID
        RegionEndpoint.USEast1 // Region
        );

        //S3 client
        IAmazonS3 s3Client = new AmazonS3Client(<credentials>, _S3Region);



        // ResultText is a label used for displaying status information
        
        S3Client.ListBucketsAsync(new ListBucketsRequest(), (responseObject) =>
        {
            
            if (responseObject.Exception == null)
            {
                
                responseObject.Response.Buckets.ForEach((s3b) =>
                {
                    Debug.Log("Bucket Name: " + s3b.BucketName);
                };
            }
            else
            {
                Debug.Log("AWS Error");
            }
        });
    }
}
