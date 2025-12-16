using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
public class MovementPlayerController : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    [SerializeField] InputActionReference move;
    [SerializeField] InputActionReference shoot;
    [SerializeField] InputActionReference jump;

    Vector2 rawMove = Vector2.zero;

    private void OnEnable()
    {
        move.action.Enable();
        shoot.action.Enable();
        jump.action.Enable();

        jump.action.started += OnJump;

        move.action.started += OnMove;
        move.action.performed += OnMove;
        move.action.canceled += OnMove;

        
    }
    private void Update()
    {
        Vector3 moveToApply = new Vector3(rawMove.x, 0f, rawMove.y) * Speed * Time.deltaTime;
        transform.Translate(moveToApply);
    }

    private void OnDisable()
    {
        move.action.started -= OnMove;
        move.action.performed -= OnMove;
        move.action.canceled -= OnMove;

        jump.action.started -= OnJump;

        move.action.Disable();
        shoot.action.Disable();
        jump.action.Disable();
    }
    bool isJumping = false;
    void OnMove(InputAction.CallbackContext ctx)
    {
        rawMove = ctx.ReadValue<Vector2>();
    }
    private void OnJump(InputAction.CallbackContext ctx)
    {
        isJumping = ctx.ReadValueAsButton();

    }
}
