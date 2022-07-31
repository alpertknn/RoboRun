using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Numerics;
using System.Globalization;
using System.Runtime;
using System.Linq.Expressions;
using System;
using System.Random;
void Update()
{
if (counter<countertarget)
{
    counter=0;
    speed*=1.2f
}

counter+=Time.deltaTime;
isGrounded=controller.isGrounded;

if(isGrounded && movevector.y<0)
{
    movevector.y=0f;
}

Vector3 move=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
controller.Move(move*Time.deltaTime*speed);
if (move!=Vector3.zero)
{
    gameObject.transform.forward=move;
}
// Changes the height position of the player


if (Input.GetButtonDown("Jump") && isGrounded)
{
    movevector.y+=Math.Sqrt(jumpForce*-3.0f*gravity);
}
movevector.y+=gravity*Time.deltaTim
controller.Move(movevector*Time.deltaTime);


}
