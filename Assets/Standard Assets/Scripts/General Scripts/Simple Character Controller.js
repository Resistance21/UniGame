var walkspeed: float = 5.0;
var jumpheight: float = 250.0;
var grounded = false;

function Start() {



}


function Update() {

    rigidbody.freezeRotation = true;

    if (Input.GetKey("w")) transform.Translate(Vector3(0, 0, 1) * Time.deltaTime * walkspeed);
    if (Input.GetKey("s")) transform.Translate(Vector3(0, 0, - 1) * Time.deltaTime * walkspeed);
    if (Input.GetKey("a")) transform.Translate(Vector3(-1, 0, 0) * Time.deltaTime * walkspeed);
    if (Input.GetKey("d")) transform.Translate(Vector3(1, 0, 0) * Time.deltaTime * walkspeed);

    if (Input.GetButton("Jump")) {
        Jump();
    }
}

function OnCollisionEnter(hit: Collision) {
    grounded = true;
}

function Jump() {
    if (grounded == true) {
        rigidbody.AddForce(Vector3.up * jumpheight);
        grounded = false;
    }
}