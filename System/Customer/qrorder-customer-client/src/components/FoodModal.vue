<template>
  <div class="modal fade" id="foodModal" tabindex="-1">
    <div
      class="modal-dialog modal-dialog-centered modal-dialog-scrollable modal-fullscreen-sm-down"
      style="max-width: 700px">
      <div class="modal-content">
        <ModalHeader />

        <div class="modal-body p-0">
          <img
            src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYm2LKmGDspWPFpuf2cSqBAvQiW4LTcHAPaw&usqp=CAU"
            class="object-fit-cover w-100"
            style="max-height: 300px" />

          <div class="p-3">
            <p class="card-text fs-5 mb-2">
              <strong>マグロの中マグロ</strong>
            </p>

            <p class="card-text fs-5 mb-2">
              <strong>
                <span class="text-danger me-1">$ 2,099</span>
                <small class="text-secondary">税込み</small>
              </strong>
            </p>

            <p class="card-text text-secondary">
              詳細詳細詳細詳細詳細詳詳,細詳細詳細詳細詳細詳詳細詳細詳細詳細詳細詳細詳,細詳細詳詳細詳細詳細詳細詳細詳詳細詳細詳細詳細詳細詳細,詳細詳細詳詳細詳.
            </p>
          </div>

          <hr class="border opacity-50" />

          <div class="px-4">
            <label class="form-label"><strong>辛さ</strong></label>
            <div class="form-check py-2">
              <input
                class="form-check-input"
                type="radio"
                name="flexRadioDefault"
                id="flexRadioDefault1" />
              <label class="form-check-label d-flex" for="flexRadioDefault1">
                <span class="flex-grow-1">
                  小辛さ小辛さ小辛さ小辛さ小辛さ小辛さ小辛さ小辛さ小辛さ小辛さ
                </span>
                <span>+$0.50</span>
              </label>
            </div>
            <div class="form-check py-2">
              <input
                class="form-check-input"
                type="radio"
                name="flexRadioDefault"
                id="flexRadioDefault2"
                checked />
              <label class="form-check-label d-flex" for="flexRadioDefault2">
                <span class="flex-grow-1">中辛さ</span>
                <span>+$0.50</span>
              </label>
            </div>
          </div>

          <hr class="border opacity-50" />

          <div class="px-4">
            <label class="form-label"><strong>辛さ</strong></label>
            <div class="form-check py-2">
              <input
                class="form-check-input"
                type="checkbox"
                value=""
                id="flexCheckDefault" />
              <label class="form-check-label d-flex" for="flexCheckDefault">
                <span class="flex-grow-1">ビーフ</span>
                <span>+$0.50</span>
              </label>
            </div>
            <div class="form-check py-2">
              <input
                class="form-check-input"
                type="checkbox"
                value=""
                id="flexCheckChecked"
                checked />
              <label class="form-check-label d-flex" for="flexCheckChecked">
                <span class="flex-grow-1">ラーム肉</span>
                <span>+$0.80</span>
              </label>
            </div>
          </div>

          <hr class="border opacity-50" />

          <div class="px-4">
            <label class="form-label"><strong>説明</strong></label>
            <textarea
              class="form-control"
              id="exampleFormControlTextarea1"
              rows="4"></textarea>
          </div>

          <p class="card-text text-end p-4">
            <button type="button" class="btn btn-sm btn-light rounded-circle">
              <i class="bi bi-dash-lg" />
            </button>
            <span class="text-secondary mt-1 px-2" style="width: 18px">0</span>
            <button type="button" class="btn btn-sm btn-light rounded-circle">
              <i class="bi bi-plus-lg" />
            </button>
          </p>
        </div>

        <div class="d-grid">
          <button class="btn btn-danger rounded-pill m-2" type="button">
            <i class="bi bi-cart-plus me-1" style="font-size: 18px" />
            <span class="me-1">カートに入れる</span>
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import ModalHeader from "@/components/ModalHeader.vue";

export default {
  components: { ModalHeader },
};
</script>

<style scoped></style>
