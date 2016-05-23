using UnityEngine;
using System.Collections;

public class PS4_Input : MonoBehaviour {

	void Update () {
		////////////////////////////////////////////
		//Buttons///////////////////////////////////
		////////////////////////////////////////////
		if(Input.GetButtonDown("PS4_X")){
			print("X");
		}

		if(Input.GetButtonDown("PS4_O")){
			print("O");
		}

		if(Input.GetButtonDown("PS4_Triangle")){
			print("Triangle");
		}

		if(Input.GetButtonDown("PS4_Square")){
			print("Square");
		}

		////////////////////////////////////////////
		//Left Stick////////////////////////////////
		////////////////////////////////////////////
		if(Input.GetAxis("PS4_L_Horizontal")>0.1){
			print("Left Stick Right");
		}

		if(Input.GetAxis("PS4_L_Horizontal")<-0.1){
			print("Left Stick Left");
		}

		if(Input.GetAxis("PS4_L_Vertical")<-0.1){
			print("Left Stick Up");
		}

		if(Input.GetAxis("PS4_L_Vertical")>0.1){
			print("Left Stick Down");
		}

		if(Input.GetButtonDown("PS4_L_Bnt")){
			print("Left Stick Button");
		}

		////////////////////////////////////////////
		//Right Stick///////////////////////////////
		////////////////////////////////////////////
		if(Input.GetAxis("PS4_R_Horizontal")>0.1){
			print("Right Stick Right");
		}

		if(Input.GetAxis("PS4_R_Horizontal")<-0.1){
			print("Right Stick Left");
		}

		if(Input.GetAxis("PS4_R_Vertical")<-0.1){
			print("Right Stick Up");
		}

		if(Input.GetAxis("PS4_R_Vertical")>0.1){
			print("Right Stick Down");
		}

		if(Input.GetButtonDown("PS4_R_Bnt")){
			print("Right Stick Button");
		}

		////////////////////////////////////////////
		//Bumper Buttons////////////////////////////
		////////////////////////////////////////////
		if(Input.GetAxis("PS4_R2")>-0.1){
			print("R2");
		}

		if(Input.GetAxis("PS4_L2")>-0.1){
			print("L2");
		}

		if(Input.GetButtonDown("PS4_R1")){
			print("R1");
		}

		if(Input.GetButtonDown("PS4_L1")){
			print("L1");
		}

		////////////////////////////////////////////
		//D-Pad/////////////////////////////////////
		////////////////////////////////////////////
		if(Input.GetAxis("PS4_D_Y")==1){
			print("D-Pad Up");
		}

		if(Input.GetAxis("PS4_D_Y")==-1){
			print("D-Pad Down");
		}
		if(Input.GetAxis("PS4_D_X")==1){
			print("D-Pad Right");
		}

		if(Input.GetAxis("PS4_D_X")==-1){
			print("D-Pad Left");
		}

		////////////////////////////////////////////
		//PS4 Buttons///////////////////////////////
		////////////////////////////////////////////
		if(Input.GetButtonDown("PS4_Options")){
			print("Options");
		}

		if(Input.GetButtonDown("PS4_Share")){
			print("Share");
		}

		if(Input.GetButtonDown("PS4_Pad")){
			print("Touch Pad");
		}

		if(Input.GetButtonDown("PS4_PS")){
			print("PlayStation");
		}
	
	}
}
