/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function(l1, l2) {
    let dummy = new ListNode(0);
    let tail = dummy;
    let carry = 0;

    while (l1 !== null || l2 !== null || carry !== 0) {
        let a = l1 ? l1.val : 0;
        let b = l2 ? l2.val : 0;

        let total = a + b + carry;
        carry = Math.floor(total / 10);

        tail.next = new ListNode(total % 10);
        tail = tail.next;

        if (l1) l1 = l1.next;
        if (l2) l2 = l2.next;
    }

    return dummy.next;
};