
module HeapSort

let rec Heapify(nums: int[], n: int, i: int) =
  let mutable largest = i
  let mutable left = i * 2 + 1
  let mutable right = i * 2 + 2

  // ���̎q�m�[�h���ő�̏ꍇ
  if left < n && nums.[left] > nums.[largest] then
    largest <- left

  // �E�̎q�m�[�h���ő�̏ꍇ
  if right < n && nums.[right] > nums.[largest] then
    largest <- right

  // �ő�̎q�m�[�h���e�m�[�h���傫���ꍇ�A�������čċA�Ăяo��
  if largest <> i then
    let temp = nums.[i]
    nums.[i] <- nums.[largest]
    nums.[largest] <- temp

    Heapify(nums, n, largest)

let HeapSort(nums: int[]) =
  let mutable n = Array.length nums

  // �ő�q�[�v���\�z
  for i = n / 2 - 1 downto 0 do
    Heapify(nums, n, i)

  // �q�[�v����v�f��1�����o���A�����Ƀ\�[�g
  for i = n - 1 downto 0 do
    // �ő�l�����o���A�z��̖����ƌ���
    let temp = nums.[0]
    nums.[0] <- nums.[i]
    nums.[i] <- temp

    // �q�[�v���č\�z
    n <- n - 1
    Heapify(nums, n, 0)

  nums
