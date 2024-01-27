<template>
  <div class="modal fade" id="cartModal" tabindex="-1">
    <div
      class="modal-dialog modal-dialog-centered modal-dialog-scrollable modal-fullscreen-sm-down"
      style="max-width: 700px">
      <div class="modal-content">
        <ModalHeader />

        <div class="modal-body p-0">
          <h1 class="text-center p-4">Cart</h1>
        </div>

        <div class="d-grid">
          <button class="btn btn-danger rounded-pill m-2" type="button">
            <i class="bi bi-cart-check me-1" style="font-size: 18px" />
            <span class="me-1">注文する</span>
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
